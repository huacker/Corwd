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
    public class CrowdProjectListController:BaseController
    {
        CrowdfundingSolutionEntities db = new CrowdfundingSolutionEntities();
        public ViewResult CrowdProjectListQuery()
        {
            var bs = new DAO.Basic();
            
            return View(bs);
        }

    }
}