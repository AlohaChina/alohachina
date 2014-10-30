
using System.Collections.Generic;
namespace Me.AlohaChina.Data.Identity
{
    public class User
    {
        public string UserName
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }
        public IList<Role> Roles
        {
            get;
            set;
        }

        public IList<Claim> Claims
        {
            get;
            set;
        }

        public IList<ApplicationUser> ApplicationUsers
        {
            get;
            set;
        }
    }
}
