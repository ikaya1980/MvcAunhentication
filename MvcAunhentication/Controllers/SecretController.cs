using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MvcAunhentication.Controllers
{
    [Authorize]
    public class SecretController : Controller
    {        
        [AllowAnonymous]
        public ContentResult Index()
        {
            #region old code
            //StringBuilder message = new StringBuilder();

            //message.AppendLine("This is a secret.");
            //message.AppendLine("User is authenticated.");

            //if (User.Identity.IsAuthenticated)//veya Request.IsAuthenticated
            //{
            //    message.AppendLine("This is a secret.");
            //    message.AppendLine("User is authenticated.");
            //}
            //else
            //{
            //    message.AppendLine("User is not authenticated.");
            //}

            //return Content(message.ToString());

            #endregion

            return Content("This is not a secret");
        }
                
        public ContentResult Secret()
        {
            StringBuilder message = new StringBuilder();

            message.AppendLine("This is a secret.");
            message.AppendLine("User is authenticated.");

            return Content(message.ToString());
        }
    }
}