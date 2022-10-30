using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;

namespace LibPlugifyCS
{
    public class PlugifyCSClient
    {
        private PlugifyWebSocketClient ws = new PlugifyWebSocketClient("wss://api.impulse.chat/");
        private string Token;
        private dynamic UserInfo;
        private dynamic _groups;
        private dynamic tmp;
        private dynamic _GetChannelDetails;
        private dynamic _GetGroups;

        private bool LoginError = false;

        public delegate void PlugifyEvent(dynamic data);
        public delegate void PlugifyGroupEvent(PlugifyGroup gc);

        public event PlugifyGroupEvent OnGroupJoin;
        public event PlugifyEvent OnChannelCreated;
        public event PlugifyEvent OnGroupRemoved;

        public PlugifyUser CurrentUser { get; private set; }

        public List<PlugifyGroup> Groups = new List<PlugifyGroup>();
        public async Task Start(string token, bool AuthOnlyMode = false)
        {
            this.Token = token;
            ws.OnMessage += Ws_OnMessage;

            await ws.Start();
            Console.WriteLine("client: begin auth");
            int timeout = 0;
            while (true)
            {
                if (LoginError)
                {
                    throw new Exception("Invaild token.");
                }
                if (UserInfo != null)
                {
                    //Successful connection
                    break;
                }
                await Task.Delay(1);
                //timeout++;
                //Console.WriteLine("t: " + timeout);
                //if (timeout == 1220)
                //{
                //    throw new Exception("Timeout reached while waiting for user message");
                //}
            }
            Console.WriteLine("client: authentication success");

            if (AuthOnlyMode)
                return;

            Console.WriteLine("client: parse user data");
            CurrentUser = UserFromStructure(UserInfo.data);
            Console.WriteLine("client: refresh groups");
            await RefreshGroupsArray();
            Console.WriteLine("client: connection success");
        }

        internal static PlugifyUser UserFromStructure(dynamic data)
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

        public static PlugifyGroup GroupFromStructure(dynamic data)
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

        private async void Ws_OnMessage(object sender, string e)
        {
            Console.WriteLine("rx: " + e);
            var obj = JObject.Parse(e);
            dynamic d = obj;
            var eventID = (PlugifyGatewayMessages)obj.Value<int>("event");
            Console.WriteLine("gateway: got: "+eventID);
            switch (eventID)
            {
                case PlugifyGatewayMessages.WELCOME:
                    await ws.Send("{\"event\": 1, \"data\": {\"token\": \"" + Token + "\"}}");
                    break;
                case PlugifyGatewayMessages.AUTHENTICATE:
                    if ((bool)d.success == true)
                    {
                        //vaild token
                        UserInfo = d;
                    }
                    else
                    {
                        LoginError = true;
                    }
                    break;
                case PlugifyGatewayMessages.APP_LOGIN_AUTHENTICATE:
                    break;
                case PlugifyGatewayMessages.APP_LOGIN:
                    break;
                case PlugifyGatewayMessages.SYSTEM_ANNOUNCEMENT:
                    break;
                case PlugifyGatewayMessages.GROUPS_GET:
                    _GetGroups = d;
                    break;
                case PlugifyGatewayMessages.GROUP_NEW:
                    var gc = GroupFromStructure(d.data);
                    Groups.Add(gc);
                    if (OnGroupJoin != null) OnGroupJoin(gc);
                    break;
                case PlugifyGatewayMessages.GROUP_UPDATE:
                    break;
                case PlugifyGatewayMessages.GROUP_REMOVE:
                    if (OnGroupRemoved != null) OnGroupRemoved(d.data);
                    break;
                case PlugifyGatewayMessages.CHANNELS_GET:
                    break;
                case PlugifyGatewayMessages.CHANNEL_CREATE:
                    break;
                case PlugifyGatewayMessages.CHANNEL_UPDATE:
                    break;
                case PlugifyGatewayMessages.CHANNEL_REMOVE:
                    break;
                case PlugifyGatewayMessages.CHANNEL_DISCONNECT:
                    break;
                case PlugifyGatewayMessages.CHANNEL_HISTORY:
                    break;
                case PlugifyGatewayMessages.CHANNEL_JOIN:
                    break;
                case PlugifyGatewayMessages.MEMBER_CREATE:
                    break;
                case PlugifyGatewayMessages.MEMBER_UPDATE:
                    break;
                case PlugifyGatewayMessages.MEMBER_REMOVE:
                    break;
                case PlugifyGatewayMessages.GROUP_BAN_CREATE:
                    break;
                case PlugifyGatewayMessages.GROUP_BAN_UPDATE:
                    break;
                case PlugifyGatewayMessages.MESSAGE_SEND:
                    break;
                case PlugifyGatewayMessages.MESSAGE_CREATE:
                    break;
                case PlugifyGatewayMessages.MESSAGE_UPDATE:
                    break;
                case PlugifyGatewayMessages.MESSAGE_REMOVE:
                    break;
                case PlugifyGatewayMessages.ROLE_UPDATE:
                    break;
                case PlugifyGatewayMessages.ROLE_REMOVE:
                    break;
                case PlugifyGatewayMessages.MEMBER_LIST:
                    break;
                case PlugifyGatewayMessages.MEMBER_LIST_UPDATE:
                    break;
                case PlugifyGatewayMessages.PING:

                    break;
                default:
                    Console.WriteLine("gateway: Message ID: " + (int)eventID + " not implemented");
                    break;
            }
        }

        public async Task<dynamic> GetGroupInfo(string id)
        {
            tmp = null;
            await ws.Send("{\"event\":9,\"data\": {\"groupID\": \"" + id + "\"}}");

            while (tmp == null)
            {
                await Task.Delay(1);
            }
            return tmp;
        }

        public async Task<dynamic> GetChannelDetails(string id)
        {
            _GetChannelDetails = null;

            //Get channel details
            string s3 = "{\"event\":15,\"data\":{\"id\":\"" + id.TrimStart('{').TrimEnd('}') + "\"}}";
            await ws.Send(s3);

            while (_GetChannelDetails == null)
            {
                await Task.Delay(1);
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
                await Task.Delay(1);
            }
            return tmp;
        }

        public async Task<dynamic> GetGroups()
        {
            _GetGroups = null;

            //Get groups
            await ws.Send("{\"event\":5,\"data\":null}");

            while (_GetGroups == null)
            {
                await Task.Delay(1);
            }
            return _GetGroups;
        }

        public async Task SendPing()
        {
            await ws.Send("{\"event\":9001}");
        }

        public async Task RefreshGroupsArray()
        {
            Groups = new List<PlugifyGroup>();
            var g = await GetGroups();
            foreach (var group in g.data)
            {
                Groups.Add(GroupFromStructure(group));
            }
        }

        public PlugifyApiResult LeaveServer(string id)
        {
            return ToResult(DoApi("https://api.impulse.chat/v2/members/" + id + "/" + CurrentUser.UserName, "DELETE"));
        }
        private PlugifyApiResult ToResult(dynamic x)
        {
            if (x == null)
            {
                return new PlugifyApiResult((bool)x.success, "<internal client error: object provided is null>");
            }
            if ((bool)x.success)
            {
                return new PlugifyApiResult((bool)x.success, 0);
            }
            else
            {
                return new PlugifyApiResult((bool)x.success, (int)x.error);
            }
        }
        private dynamic DoApi(string url, string method, string content = "")
        {
            var webRequest = System.Net.WebRequest.Create(url);
            webRequest.Method = method;
            webRequest.ContentType = "application/json";
            webRequest.Headers.Add("Authorization", Token);

            if (method == "GET" || method == "POST")
            {
                //write the input data (aka post) to a byte array
                byte[] requestBytes = new ASCIIEncoding().GetBytes(content);
                //get the request stream to write the post to
                Stream requestStream = webRequest.GetRequestStream();
                //write the post to the request stream
                requestStream.Write(requestBytes, 0, requestBytes.Length);
            }
            WebResponse r;
            try
            {
                r = webRequest.GetResponse();
            }
            catch (WebException e)
            {
                r = e.Response;
            }

            using (Stream s = r.GetResponseStream())
            {
                using (StreamReader sr = new StreamReader(s))
                {
                    var jsonResponse = sr.ReadToEnd();
                    return JObject.Parse(jsonResponse);
                }
            }
        }
    }

    public enum PlugifyGatewayMessages
    {
        WELCOME,

        AUTHENTICATE,

        APP_LOGIN_AUTHENTICATE,
        APP_LOGIN,

        SYSTEM_ANNOUNCEMENT,

        GROUPS_GET,
        GROUP_NEW,
        GROUP_UPDATE,
        GROUP_REMOVE,

        CHANNELS_GET,
        CHANNEL_CREATE,
        CHANNEL_UPDATE,
        CHANNEL_REMOVE,
        CHANNEL_DISCONNECT,
        CHANNEL_HISTORY,
        CHANNEL_JOIN,

        MEMBER_CREATE,
        MEMBER_UPDATE,
        MEMBER_REMOVE,

        GROUP_BAN_CREATE,
        GROUP_BAN_UPDATE,

        MESSAGE_SEND,
        MESSAGE_CREATE,
        MESSAGE_UPDATE,
        MESSAGE_REMOVE,

        ROLE_UPDATE,
        ROLE_REMOVE,

        MEMBER_LIST,
        MEMBER_LIST_UPDATE,

        PING = 9001
    }

    public class PlugifyApiResult
    {
        public bool Success { get; set; } = false;
        public string ErrorMessage { get; set; }
        public int ErrorCode { get; set; }

        public PlugifyApiResult(bool Success, int ErrorCode)
        {
            this.Success = Success;
            this.ErrorCode = ErrorCode;

            ErrorMessage = PlugifyErrorCode.Tostring(ErrorCode);
        }

        public PlugifyApiResult(bool Success, string error)
        {
            this.Success = Success;
            this.ErrorCode = -1;


            ErrorMessage = error;
        }
    }
}