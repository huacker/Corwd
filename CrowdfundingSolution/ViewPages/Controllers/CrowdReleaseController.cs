using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
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
    public class CrowdReleaseController :BaseController
    {
        CrowdfundingSolutionEntities db = new CrowdfundingSolutionEntities();
        public CrowdReleaseController()
        {
            
        }
        [HttpGet]
        public ViewResult ReleaseAdd()
        {
            return View();
        }
        [HttpGet]
        public ViewResult BasicInformationAdd(string id)
        {
            id = "329d4bf6-8240-487b-96bd-f54f88cb28d8";
            var bif = db.Basic.Find(id);
            ViewBag.ProjectName = bif.ProjectName;
            ViewBag.ID = bif.ID;
            return View(bif);
        }
        [HttpPost]
        public ActionResult ReleaseAdd(string ProjectName, string Synopsis, string Industry, string province)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data["ProjectName"] = ProjectName;
            data["Synopsis"] = Synopsis;
            data["Industry"] = Industry;
            data["province"] = province;

            ICrowdRelease Release = new CrowdReleaseBLL();
            Release.ReleaseAdd(data);
            //return RedirectToAction("News", "User");
            return View();
            //if (ModelState.IsValid)
            //{
            //    Dictionary < string, string> data = new Dictionary<string, string>();
            //    data["ProjectName"] = ProjectName;
            //    data["Synopsis"] = Synopsis;
            //    data["Industry"] = Industry;
            //    data["province"] = province;

            //    ICrowdRelease Release = new CrowdReleaseBLL();
            //    Release.ReleaseAdd(data);
            //    return RedirectToAction("ReleaseAdd");
            //}
            //return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult BasicInformationAdd([Bind(Include = "ID,Highlight,Promoter,Website,BusinessProgress,BaseCity,FoundingTime,Tags,Stage,IsHaveOther,CompanyName,CompanyAddress,ShareholderCount,EmployeesCount,ProjectDate")]CrowdBasicInformationModels CBIM,string ID)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data["Highlight"] = CBIM.Highlight;
            data["Promoter"] = CBIM.Promoter;
            data["Website"] = CBIM.Website;

            data["BusinessProgress"] = CBIM.BusinessProgress;
            data["BaseCity"] = CBIM.BaseCity;
            data["FoundingTime"] = CBIM.FoundingTime;
            data["Tags"] = CBIM.Tags;
            data["Stage"] = CBIM.Stage;
            data["IsHaveOther"] = CBIM.IsHaveOther;
            data["CompanyName"] = CBIM.CompanyName;
            data["CompanyAddress"] = CBIM.CompanyAddress;
            data["ShareholderCount"] = CBIM.ShareholderCount;
            data["EmployeesCount"] = CBIM.EmployeesCount;
            data["ProjectDate"] = CBIM.ProjectDate;
            ICrowdRelease plan = new CrowdReleaseBLL();
            plan.BasicInformationAdd(CBIM.ID,data);
            return View();
        }
    }
}