using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MulticluehnSolution.EntityModel;
using MulticluehnSolution.Common.Base;
using MulticluehnSolution.WCFClient;
using MulticluehnSolution.Common.Utility;

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


        public ActionResult Update(string ID)
        {
            ID = "b48f0b40-cc0a-4f28-9bd0-404fa09b21aa";
            string strModel = client.GetCrowdPlanByID(ID);
            CrowdfundingPlanEntityModel model = SerializeHelper.XmlDeserialize<CrowdfundingPlanEntityModel>(strModel);

            return View(model);
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
                client.Update(SerializeHelper.XmlSerialize<CrowdfundingPlanEntityModel>(model));
            }
            return View(model);
        }
    }
}