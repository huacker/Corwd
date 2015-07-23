using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MulticluehnSolution.EntityModel;
using MulticluehnSolution.Common.Base;
using MulticluehnSolution.WCFClient;
using MulticluehnSolution.Common.Utility;
using System.Net;

namespace MulticluehnSolution.Web.Controllers
{
    public class CrowdfundingPlanController : BaseController
    {
        WcfService.ServiceClient client = new WcfService.ServiceClient();
        // GET: CrowdfundingPlan
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Index()
        {
            string strMode = client.CrowdfundingPlanGetAll();
            List<CrowdfundingPlanEntityModel> lstMode = SerializeHelper.XmlDeserialize<List<CrowdfundingPlanEntityModel>>(strMode);
            return View(lstMode);
        }

        public ActionResult Update(string ID)
        {
            ID = "b48f0b40-cc0a-4f28-9bd0-404fa09b21aa";
            string strModel = client.CrowdfundingPlanGetByID(ID);
            CrowdfundingPlanEntityModel model = SerializeHelper.XmlDeserialize<CrowdfundingPlanEntityModel>(strModel);

            return View(model);
        }

        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            string strModel = client.CrowdfundingPlanGetByID(id);
            CrowdfundingPlanEntityModel model = SerializeHelper.XmlDeserialize<CrowdfundingPlanEntityModel>(strModel);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // GET: MovieDBs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            string strModel = client.CrowdfundingPlanGetByID(id);
            CrowdfundingPlanEntityModel model = SerializeHelper.XmlDeserialize<CrowdfundingPlanEntityModel>(strModel);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Add(CrowdfundingPlanEntityModel model)
        {
            string str = string.Empty;
            if (ModelState.IsValid)
            {
                //IServiceFactory service = MulticluehnSolution.Web.App_Start.WCFClientFactory.ServiceFactory;
                //service.CreateService().CrowdfundingPlanAdd(model);
                //str = client.TestGetData("习近平");
                model.ID = Guid.NewGuid().ToString();
                client.CrowdfundingPlanAdd(SerializeHelper.XmlSerialize<CrowdfundingPlanEntityModel>(model));
            }
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Update(CrowdfundingPlanEntityModel model)
        {
            string str = string.Empty;
            if (ModelState.IsValid)
            {
                model.ID = Guid.NewGuid().ToString();
                client.CrowdfundingPlanUpdate(SerializeHelper.XmlSerialize<CrowdfundingPlanEntityModel>(model));
            }
            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            client.CrowdfundingPlanDelete(id);
            return RedirectToAction("Index");
        }
    }
}