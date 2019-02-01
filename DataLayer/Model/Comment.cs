using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Model
{
    public class Comment
    {
        public int Id { get; set; }
       
        [StringLength(50, MinimumLength = 3, ErrorMessage = "توضیحات دسته باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name = "متن نظر")]
        public string Description { get; set; }
        public int Rating { get; set; }
        [Display(Name ="نمایش نظر")]
        //Show = true
        public bool Status { get; set; }
        [Display(Name = "کاربر")]
        [ForeignKey("User")]
        public int UserCode { get; set; }
        [Display(Name = "فروشگاه")]
        [ForeignKey("Store")]
        public int? StoreCode { get; set; }
        [Display(Name = "محصول")]
        [ForeignKey("Product")]
        public int? ProductCode { get; set; }
        [Display(Name = "سرویس")]
        [ForeignKey("Service")]
        public int? ServiceCode { get; set; }
        public virtual Store Store { get; set; }
        public virtual Product Product { get; set; }
        public virtual Service Service { get; set; }
        public virtual User User { get; set; }
    }
}
