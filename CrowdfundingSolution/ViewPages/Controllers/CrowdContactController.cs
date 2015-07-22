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
    public class CrowdContactController:BaseController
    {
        CrowdfundingSolutionEntities db = new CrowdfundingSolutionEntities();
        public CrowdContactController()
        {

        }
        //public ViewResult ContactAdd()
        //{
        //    return View();
        //}
        public ViewResult ContactAdd(string id)
        {
            id = "329d4bf6-8240-487b-96bd-f54f88cb28d8";

            ViewBag.ProjectName = db.Basic.Find(id).ProjectName;

            return View();

        }

        [HttpPost]
        public ActionResult ContactAdd(FormCollection coll)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data["QQ"] = coll["QQ"];
            data["PhoneNum"] = coll["PhoneNum"];
            data["Qqun"] = coll["Qqun"];
            data["Wqun"] = coll["Wqun"];

            ICrowdContact Contact = new CrowdContactBLL();
            Contact.ContactAdd(data);
            return View();
        }
    }
}