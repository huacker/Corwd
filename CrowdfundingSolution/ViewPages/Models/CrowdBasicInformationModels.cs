using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Web;
using System.Web.Mvc;

namespace ViewPages.Models
{
    public class CrowdBasicInformationModels
    {
        public string ID { get; set; }
        [Display(Name = "项目名称")]
        public string ProjectName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "项目一句话亮点")]
        public string Highlight { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "项目发起人")]
        public string Promoter { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "网站网址")]
        public string Website { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "经营进度")]
        public string BusinessProgress { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "企业所在城市")]
        public string BaseCity { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "企业成立时间")]
        public string FoundingTime { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "项目标签")]
        public string Tags { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "项目所属阶段")]
        public string Stage { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "是否有其他项目")]
        public string IsHaveOther { get; set; }
        //public bool IsHaveOtherForBool { get; set; }


        [Required]
        [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "公司名称")]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "公司地址")]
        public string CompanyAddress { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "股东人数")]
        public string ShareholderCount { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "企业员工总数")]
        public string EmployeesCount { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
        [Display(Name = "项目成立时间")]
        public string ProjectDate { get; set; }
    }
}