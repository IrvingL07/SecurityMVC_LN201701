using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSecurityDemo_LN201701.Controllers
{
    [Authorize(Users = "ali.khan@outlook.com")]
    public class SecretController : Controller
    {
        // GET: Secret
        /* public ActionResult Index()
         {
             return View();
         }
        */
        
            public ContentResult Secret()
        {
            return Content("Secret informations here");
        }

        [AllowAnonymous]
        public ContentResult PublicInfo()
        {
            return Content("Public informations here");
        }
    }
  
}