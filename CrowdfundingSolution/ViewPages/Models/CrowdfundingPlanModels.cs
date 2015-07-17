using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Web;
using System.Web.Mvc;

namespace ViewPages.Models
{
    //[Bind(Include = "ShortAlias，CrowdfundingPlan，CrowdfundingAmount，Percentage，Prerelease，BegingDate,EndDate")]
    public class CrowdfundingPlanModels
    {
        [Required]
        [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "项目简称")]
        public string ShortAlias { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "众筹方案")]
        public string CrowdfundingPlan { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]*$",ErrorMessage ="必须是数字")]
        [Display(Name = "筹资金额")]
        public string CrowdfundingAmount { get; set; }

        [Required(ErrorMessage = "比例必须大于0小于100的数字")]
        [Range(0, 100)]
        [Display(Name = "股份比例")]
        public string Percentage { get; set; }

        [Required]
        [Display(Name = "预热开始时间")]
        public string Prerelease { get; set; }

        [Required]
        [Display(Name = "认投开始时间")]
        public string BegingDate { get; set; }

        [Required]
        [Display(Name = "认投结束时间")]
        public string EndDate { get; set; }

    }
}
