using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPlugifyCS
{
    public static class PlugifyErrorCode
    {
        public static string Tostring(int error)
        {
            switch (error)
            {
                case 0:
                    return "Unknown backend error";
                case 1:
                    return "API error: missing token in Authorization header";
                case 2:
                    return "API error: invaild token";
                case 3:
                    return "API error: missing or incorrect types in JSON. Try updating your plugify CS version";
                case 4:
                    return "The recaptchaToken has an incorrect token.";
                case 5:
                    return "The email is invaild";
                case 6:
                    return "The email is already used";
                case 7:
                    return "The username is already used.";
                case 8:
                    return "The user does not exist";
                case 9:
                    return "The group does not exist";
                case 10:
                    return "The password is incorrect. Try again";
                case 11:
                    return "The user is not verified";
                case 12:
                    return "The verification token is invaild";
                case 13:
                    return "The invite does not exist";
                case 14:
                    return "The user does not have sufficient permissions.";
                case 15:
                    return "The private beta invite code doesn't exist";
                case 16:
                    return "The username is invaild";
                case 17:
                    return "You are already in this group";
                case 18:
                    return "This application does not exist";
                case 19:
                    return "This application secret does not exist";
                case 20:
                    return "This channel does not exist";
                case 21:
                    return "This member does not exist";
                case 22:
                    return "This user has been banned";
                case 23:
                    return "Error: this user is currently not banned";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
