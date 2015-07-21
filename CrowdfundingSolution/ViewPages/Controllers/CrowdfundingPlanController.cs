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
            CrowdfundingPlanModels modelst = new CrowdfundingPlanModels();

            List<DAO.CrowdfundingPlan> planlst = plan.GetCrowdPlanByID(ID);
            if (planlst.Count > 0 )
            {
                modelst.BegingDate = planlst[0].BegingDate;
                modelst.CrowdfundingAmount = planlst[0].CrowdfundingAmount;
                modelst.CrowdfundingPlan = planlst[0].CrowdfundingPlan1;
                modelst.Percentage = planlst[0].Percentage;
                modelst.Prerelease = planlst[0].Prerelease;
                modelst.ShortAlias = planlst[0].ShortAlias;
            }
            
            return View(modelst);
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
