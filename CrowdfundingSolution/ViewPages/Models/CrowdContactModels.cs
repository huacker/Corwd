using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Web;
using System.Web.Mvc;

namespace ViewPages.Models
{
    public class CrowdContactModels
    {
            [Display(Name = "项目名称")]
            public string BasicID { get; set; }

            [Required]
            [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
            [Display(Name = "QQ")]
            public string QQ { get; set; }

            [Required]
            [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
            [Display(Name = "电话号码")]
            public string PhoneNum { get; set; }

            [Required]
            [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
            [Display(Name = "QQ群号码")]
            public string Qqun { get; set; }

            [Required]
            [StringLength(50, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 4)]
            [Display(Name = "微信群号码")]
            public string Wqun { get; set; }

    }
}