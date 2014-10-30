
using System.Collections.Generic;
namespace Me.AlohaChina.Data.Identity
{
    public class Role
    {
        public string Name
        {
            get;
            set;
        }

        public IList<Claim> Claims
        {
            get;
            set;
        }
    }
}
