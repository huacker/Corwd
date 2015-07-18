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

    }
}