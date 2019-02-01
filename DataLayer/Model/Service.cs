using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Model
{
    public class Service
    {
        [Display(Name = "کد خدمت")]
        [Key]
        public int Code { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "نام باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name = "نام")]
        public string Name { get; set; }
        [StringLength(100, MinimumLength = 3, ErrorMessage = "توضیحات باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "نام دسته باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name = "دسته بندی")]
        public string Category { get; set; }
        [Display(Name = "فروشگاه")]
        [ForeignKey("Store")]
        public int? StoreCode { get; set; }
        public virtual ICollection<Gallery> Image { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}