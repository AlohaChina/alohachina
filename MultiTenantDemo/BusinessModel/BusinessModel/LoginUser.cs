
using System.ComponentModel.DataAnnotations;
using Me.Sample.Common.Resource;
namespace Me.Sample.Web.Model
{
    public class LoginUser
    {
        [Display(ResourceType = typeof(Caption), Name = "Company")]
        public string UserName { get; set; }

        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
