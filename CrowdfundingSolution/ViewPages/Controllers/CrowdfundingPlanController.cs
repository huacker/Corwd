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

        /// <summary>
        /// 修改众筹计划
        /// </summary>
        /// <param name="ID">唯一标识</param>
        /// <returns></returns>
        public ViewResult Update(string ID)

        {
            ID = "5df5c20d-d27a-4d53-92f2-554a00869d9f";
            ICrowdfundingPlan plan = new CrowdfundingPlan();
            CrowdfundingPlanModels mode = new CrowdfundingPlanModels();

            List<DAO.CrowdfundingPlan> planlst = plan.GetCrowdPlanByID(ID);
            if (planlst.Count > 0 )
            {
                mode.BegingDate = planlst[0].BegingDate.Trim();
                mode.CrowdfundingAmount = planlst[0].CrowdfundingAmount.Trim();
                mode.CrowdfundingPlan = planlst[0].CrowdfundingPlan1.Trim();
                mode.Percentage = planlst[0].Percentage.Trim();
                mode.Prerelease = planlst[0].Prerelease.Trim();
                mode.ShortAlias = planlst[0].ShortAlias.Trim();
                mode.EndDate = planlst[0].EndDate.Trim();
            }
            mode.ID = ID;
            
            return View(mode);
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

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Update([Bind(Include = "ID,ShortAlias,CrowdfundingPlan,CrowdfundingAmount,Percentage,Prerelease,BegingDate,EndDate")] CrowdfundingPlanModels crowdPlan,string ID)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data["ShortAlias"] = crowdPlan.ShortAlias;
            data["CrowdfundingPlan"] = crowdPlan.CrowdfundingPlan;
            data["CrowdfundingAmount"] = crowdPlan.CrowdfundingAmount;
            data["Percentage"] = crowdPlan.Percentage;
            data["Prerelease"] = crowdPlan.Prerelease;
            data["BegingDate"] = crowdPlan.BegingDate;
            data["EndDate"] = crowdPlan.EndDate;

            ICrowdfundingPlan plan = new CrowdfundingPlan();
            plan.Update(crowdPlan.ID, data);
            return View();//post
        }
    }
}
