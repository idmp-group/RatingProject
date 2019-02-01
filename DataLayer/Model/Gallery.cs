using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Model
{
    public class Gallery
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [StringLength(100, MinimumLength = 3, ErrorMessage = "عنوان باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name = "عنوان")]
        public string Title { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "متن جایگزین دسته باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name = "متن جایگزین")]
        public string Alt { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "توضیحات دسته باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        public string Url { get; set; }
        
        [Display(Name = "تاریخ")]
        public string Date { get; set; }
        [Display(Name = "نوع")]
        // Gallery=t |Slider=f
        public bool? Status { get; set; }
        [Display(Name = "فروشگاه")]
        [ForeignKey("Store")]
        public int? StoreCode { get; set; }
        [Display(Name = "محصول")]
        [ForeignKey("Product")]
        public int? ProductCode { get; set; }
        [Display(Name = "خدمت")]
        [ForeignKey("Service")]
        public int? ServiceCode { get; set; }
        public virtual Store Store { get; set; }
        public virtual Product Product { get; set; }
        public virtual Service Service { get; set; }

    }
}
