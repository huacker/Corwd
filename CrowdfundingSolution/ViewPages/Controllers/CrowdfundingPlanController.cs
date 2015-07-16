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
           // plan.Add();
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Add([Bind(Include = "ShortAlias，CrowdfundingPlan，CrowdfundingAmount，Percentage，Prerelease，BegingDate,EndDate")] CrowdfundingPlanModels model)//Post post
        {
            if (ModelState.IsValid)
            {
                var vl = model.ShortAlias;
                //db.Posts.Add(post);
                //await db.SaveChangesAsync();
                //return RedirectToAction("Index");
            }
            //ViewBag.CategoryId = new SelectList(db.Categories， "Id"， "Title"， post.CategoryId);
            return View(model);//post
        }
    }
}
