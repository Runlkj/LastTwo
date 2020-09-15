using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using LastProject.Controllers;

namespace LastProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : LastProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
