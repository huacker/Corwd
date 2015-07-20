using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Web;
using System.Web.Mvc;

namespace ViewPages.Models
{
    public class CrowdDetailsModels
    {
        [Display(Name ="项目名称")]
        public string BasicID { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "项目详情")]
        public string ProjectDetail { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "市场分析")]
        public string MarketAnalysis { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "盈利预测")]
        public string EarningsForecast { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "风险控制")]
        public string RiskControl { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "发展规划")]
        public string DevelopmentPlan { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "核心竞争")]
        public string CoreCompetition { get; set; }

    }
}