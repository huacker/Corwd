﻿using System;
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
        WcfService.ServiceClient client = new WcfService.ServiceClient();
        // GET: CrowdfundingPlan
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Add(CrowdfundingPlanEntityModel model)
        {
            string str = string.Empty ;
            if (ModelState.IsValid)
            {
                //IServiceFactory service = MulticluehnSolution.Web.App_Start.WCFClientFactory.ServiceFactory;
                //service.CreateService().CrowdfundingPlanAdd(model);
                str = client.TestGetData("习近平");
            }
            return View();
        }
    }
}