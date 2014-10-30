using System.Web.Mvc;
using Me.Sample.Web.Model;

namespace Me.Sample.Web.Presentation.MultiTenantsDemo.Controllers
{
    public class SecurityController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginUser user)
        {
            return View();
        }
    }
}