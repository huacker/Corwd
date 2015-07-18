using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ViewPages.Models
{
    public class CrowdReleaseModels
    {
        public string ProjectName { get; set; }
        public string Synopsis { get; set; }
        public string IndustryID { get; set; }
        public string AreaID { get; set; }
    }
}