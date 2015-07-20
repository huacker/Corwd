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
using DAO;
using System.Data.Entity;

namespace ViewPages.Controllers
{
    public class CrowdDetailsController : BaseController
    {
        CrowdfundingSolutionEntities db = new CrowdfundingSolutionEntities();
        public CrowdDetailsController()
        {

        }

        public ViewResult DetailsAdd(string id="0")
        {
            id = "329d4bf6-8240-487b-96bd-f54f88cb28d8";
            var aa=db.Basic.Find(id) ;
             
            //if (movie == null)
            //{
            //    return HttpNotFound();
            //}
            return View(aa);

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
            ICrowdDetails plan = new CrowdDetailsBLL();
            plan.DetailsAdd(data);
            return View();
        }


    }
}
