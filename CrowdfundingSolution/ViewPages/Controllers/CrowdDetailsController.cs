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

        public ViewResult DetailsAdd(string id)
        {
            id = "329d4bf6-8240-487b-96bd-f54f88cb28d8";

            ViewBag.ProjectName = db.Basic.Find(id).ProjectName;
            ViewBag.ID = db.Basic.Find(id).ID;
            return View();

        }

        [HttpPost]

        public async Task<ActionResult> DetailsAdd(FormCollection coll)
        {

            Dictionary<string, string> data = new Dictionary<string, string>();
            data["BasicID"] = coll["BasicID"];            
            data["ProjectDetail"] = coll["ProjectDetail"];
            data["MarketAnalysis"] = coll["MarketAnalysis"];
            data["EarningsForecast"] = coll["EarningsForecast"];
            data["RiskControl"] = coll["RiskControl"];
            data["DevelopmentPlan"] = coll["DevelopmentPlan"];
            data["CoreCompetition"] = coll["CoreCompetition"];
            ICrowdDetails plan = new CrowdDetailsBLL();
            plan.DetailsAdd(data);
            return View();
        }


    }
}
