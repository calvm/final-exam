using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace final_exam.Models
{
    [MetadataType(typeof(NewsMetadata))]

    public partial class News
    {
    }
    public class NewsMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "欄位 標題 必須是最大長度為50的字串")]
        [Display(Name = "標題")]
        [StringLength(50, MinimumLength = 0, ErrorMessage = "欄位 標題 必須是最大長度為50的字串")]

        public string Title { get; set; }
        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "內容")]
        public string Content { get; set; }
        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "發布日期")]
        public System.DateTime PublishDate { get; set; }
    }

}