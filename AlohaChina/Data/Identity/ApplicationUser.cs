using System;
namespace Me.AlohaChina.Data.Identity
{
    public class ApplicationUser
    {
        public string UserName
        {
            get;
            set;
        }

        public string Token
        {
            get;
            set;
        }

        public string RefreshToken
        {
            get;
            set;
        }

        public DateTime IssueDateTime
        {
            get;
            set;
        }

        public DateTime ExpiredDateTime
        {
            get;
            set;
        }

        public string AuthenticationProvider
        {
            get;
            set;
        }
    }
}
