using MulticluehnSolution.Common.Attributes;
using MulticluehnSolution.Common.WCFExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using MulticluehnSolution;

namespace MulticluehnSolution.Common.Base
{
    [AuthorizeFilter]
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            WCFContext.Current.Operater = new Operater()
            {
                Name = "Multicluehn",
                Time = DateTime.Now,
                //IP = Fetch.UserIp,
                LoginToken = Guid.NewGuid(),
                Method = filterContext.ActionDescriptor.ActionName
            };
        }
    }
}
