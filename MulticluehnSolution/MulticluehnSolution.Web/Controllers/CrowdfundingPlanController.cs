using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MulticluehnSolution.EntityModel;
using MulticluehnSolution.Common.Base;
using MulticluehnSolution.WCFClient;

namespace MulticluehnSolution.Web.Controllers
{
    public class CrowdfundingPlanController : BaseController
    {
        // GET: CrowdfundingPlan
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Add(CrowdfundingPlanEntityModel model)
        {
            if (ModelState.IsValid)
            {
                IServiceFactory service = MulticluehnSolution.Web.App_Start.WCFClientFactory.ServiceFactory;
                service.CreateService().CrowdfundingPlanAdd(model);
            }
            return View();
        }
    }
}