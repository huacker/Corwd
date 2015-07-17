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
using CrowdfundingSolution.BLLInterface;
using CrowdfundingSolution.BLLObject;
using System;
using System.Collections.Generic;

namespace ViewPages.Controllers
{
    public class CrowdfundingPlanController: BaseController
    {
        public CrowdfundingPlanController()
        {

        }

        public ViewResult Add()
        {
           // CrowdfundingPlan plan = new CrowdfundingPlan();
           // plan.Add();
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Add(FormCollection coll)//，CrowdfundingAmount，Percentage，Prerelease，BegingDate,EndDate
        {
            #region 自动绑定测试

            ////UpdateModel(model, new FormValueProvider(ControllerContext));
            //if (ModelState.IsValid)
            //{
            //    var vl = model.ShortAlias;
            //    //db.Posts.Add(post);
            //    //await db.SaveChangesAsync();
            //    //return RedirectToAction("Index");
            //}

            #endregion

            Dictionary<string,string> data = new Dictionary<string, string>();
            data["ShortAlias"] = coll["ShortAlias"];
            data["CrowdfundingPlan"] = coll["CrowdfundingPlan"];
            data["CrowdfundingAmount"] = coll["CrowdfundingAmount"];
            data["Percentage"] = coll["Percentage"];
            data["Prerelease"] = coll["Prerelease"];
            data["BegingDate"] = coll["BegingDate"];
            data["EndDate"] = coll["EndDate"];

            ICrowdfundingPlan plan = new CrowdfundingPlan();
            plan.Add(data);
            return View();//post
        }
    }
}
