using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrowdfundingSolution.BLLInterface;
using CrowdfundingSolution.BLLObject;

namespace ViewPages.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProjectList()
        {
            ICrowdfundingPlan p = new CrowdfundingPlan();
            p.GetProjectList();
            return View();
        }
    }
}