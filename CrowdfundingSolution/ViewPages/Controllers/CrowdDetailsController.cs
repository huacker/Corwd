using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using ViewPages.Models;
using CrowdfundingSolution.Base;
using CrowdfundingSolution.BLLInterface;
using CrowdfundingSolution.BLLObject;

namespace ViewPages.Controllers
{
    public class CrowdDetailsController : BaseController
    {
        public CrowdDetailsController()
        {

        }

        public ViewResult DetailsAdd()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DetailsAdd(FormCollection coll)
        {

            Dictionary<string, string> data = new Dictionary<string, string>();

            data["ProjectDetail"] = coll["ProjectDetail"];
            data["MarketAnalysis"] = coll["MarketAnalysis"];
            data["CrowdfundingAmount"] = coll["CrowdfundingAmount"];
            data["RiskControl"] = coll["RiskControl"];
            data["DevelopmentPlan"] = coll["DevelopmentPlan"];
            data["CoreCompetition"] = coll["CoreCompetition"];
            ICrowdfundingPlan plan = new CrowdfundingPlan();
            plan.Add(data);
            return View();
        }

    }
}
