using Newtonsoft.Json.Linq;
using WebSocketSharp;

namespace LibPlugifyCS
{
    public class PlugifyCSClient
    {
        private PlugifyWebSocketClient ws = new PlugifyWebSocketClient("wss://api.plugify.cf/");
        private string? Token;
        private dynamic? UserInfo;
        private dynamic? _groups;
        private dynamic? tmp;
        private dynamic? _GetChannelDetails;

        private bool LoginError = false;

        public delegate void PlugifyEvent(dynamic data);

        public event PlugifyEvent? OnGroupJoin;
        public event PlugifyEvent? OnChannelCreated;
        public event PlugifyEvent? OnGroupRemoved;

        public PlugifyUser? CurrentUser { get; private set; }

        public List<PlugifyGroup> Groups = new List<PlugifyGroup>();
        private Control? dispatch;
        public void Start(string token)
        {
            this.Token = token;
            ws.OnMessage += Ws_OnMessage;
            dispatch = new Control(); //hack to jump back to UI thread
            dispatch.CreateControl();

            ws.Start();

            while (true)
            {
                Application.DoEvents();
                if (LoginError)
                {
                    throw new Exception("Invaild token.");
                }
                if (UserInfo != null)
                {
                    //Successful connection
                    break;
                }
            }

            CurrentUser = UserFromStructure(UserInfo.data);
            while (_groups == null) Application.DoEvents();
            foreach (var group in _groups.data)
            {
                Groups.Add(GroupFromStructure(group));
            }
            _groups = null;
        }

        internal static PlugifyUser? UserFromStructure(dynamic data)
        {
            var user = new PlugifyUser();
            user.UserName = data.username;
            user.Nickname = data.displayName;

            if (data.avatarURL == "https://cds.plugify.cf/avatars/default_avatar.png")
            {
                user.PFPUrl = "https://cds.plugify.cf/defaultAvatars/" + (string)data.name;
            }
            else
            {
                user.PFPUrl = (string)data.avatarURL;
            }

            return user;
        }

        public static PlugifyGroup? GroupFromStructure(dynamic data)
        {
            var group = new PlugifyGroup();
            group.Name = data.name;
            if (data.avatarURL == "https://cds.plugify.cf/avatars/default_avatar.png")
            {
                group.ImageURL = "https://cds.plugify.cf/defaultAvatars/" + ((string)data.id).Replace("{", "").Replace("}", "");
            }
            else
            {
                group.ImageURL = (string)data.avatarURL;
            }
            if (data.members != null)
            {
                foreach (var item in data.members)
                {
                    group.Members.Add(UserFromStructure(item));
                }
            }
            group.ID = data.id;
            group.OwnerUsername = data.owner;
            return group;
        }

        public void Close()
        {
            ws.Close();
        }

        private async void Ws_OnMessage(object? sender, string e)
        {
            Console.WriteLine(e);
            var obj = JObject.Parse(e);
            dynamic d = obj;
            var eventID = obj.Value<int>("event");

            switch (eventID)
            {
                case 0: //WELCOME
                    await ws.Send("{\"event\": 1, \"data\": {\"token\": \"" + Token + "\"}}");
                    break;
                case 2: //AUTHENTICATE_SUCCESS
                    //vaild token
                    UserInfo = d;
                    await ws.Send("{\"event\":11,\"data\":null}"); //Get groups
                    break;
                case 3: //AUTHENTICATE_ERROR
                    LoginError = true;
                    break;
                case 5: //CHANNEL_JOIN_SUCCESS 
                    _GetChannelDetails = d;
                    break;
                case 12: //GROUP_GET_SUCCESS 
                    _groups = d;
                    break;
                case 14: //CHANNELS_GET_SUCCESS
                    tmp = d;
                    break;
                case 15: //JOINED_NEW_GROUP
                    dispatch.Invoke(() => { if (OnGroupJoin != null) OnGroupJoin(d.data); });
                    break;
                case 10: //MESSAGE_NEW
                    tmp = d;


                    break;
                case 8: //MESSAGE_SEND_SUCCESS 
                    //tmp = d;
                    //ignore for now
                    break;
                case 9: //MESSAGE_SEND_ERROR 
                    throw new Exception("Failed to send message");
                case 22:
                    //Group removed
                    dispatch.Invoke(() => { if (OnGroupRemoved != null) OnGroupRemoved(d.data); });
                    break;
                case 30:
                    //New channel
                    dispatch.Invoke(() => { if (OnChannelCreated != null) OnChannelCreated(d.data); });
                    break;
                case 31:
                    //When currently joined channel is unavailable
                    break;
                case 9001:
                    //ping responce
                    break;
                default:
                    throw new NotImplementedException("Message ID: " + eventID);
            }
        }

        public async Task<dynamic> GetGroupInfo(string? id)
        {
            tmp = null;
            await ws.Send("{\"event\":13,\"data\": {\"groupID\": \"" + id + "\"}}");

            while (tmp == null)
            {
                await Task.Delay(5);
            }
            return tmp;
        }

        public async Task<dynamic> GetChannelDetails(string id)
        {
            _GetChannelDetails = null;

            //Get channel details
            string s3 = "{\"event\":4,\"data\":{\"id\":\"" + id.TrimStart('{').TrimEnd('}') + "\"}}";
            await ws.Send(s3);

            while (_GetChannelDetails == null)
            {
                await Task.Delay(5);
            }
            return _GetChannelDetails;
        }

        public async Task<dynamic> SendMessage(string content, string channelId)
        {
            tmp = null;

            //Send message
            string s3 = "{\"event\":7,\"data\": {\"content\": \"" + content + "\", \"channelID\": \"" + channelId + "\"}}";
            await ws.Send(s3);

            while (tmp == null)
            {
                await Task.Delay(5);
            }
            return tmp;
        }

        public async Task<dynamic> GetGroups()
        {
            tmp = null;

            //Get groups
            await ws.Send("{\"event\":11,\"data\":null}");

            while (tmp == null)
            {
                await Task.Delay(5);
            }
            return tmp;
        }

        public async Task SendPing()
        {
            await ws.Send("{\"event\":9001}");
        }
    }
}