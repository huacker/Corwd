using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using ViewPages.Models;
using CrowdfundingSolution.Base;
using CrowdfundingSolution.BLLObject;

namespace ViewPages.Controllers
{
    public class CrowdfundingPlanController: BaseController
    {
        public CrowdfundingPlanController()
        {

        }

        public ViewResult Add()
        {
            CrowdfundingPlan plan = new CrowdfundingPlan();
            plan.Add();
            return View();
        }
    }
}
