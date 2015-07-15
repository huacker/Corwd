using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using CrowdfundingSolution.Comm.Attributes;

namespace CrowdfundingSolution.Base
{
    [AuthorizeFilter]
    public class BaseController : Controller
    {

    }
}
