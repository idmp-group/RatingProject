using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Model
{
    public class Gallery
    {
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
        // Gallery=t |Slider=f
        public bool? Status { get; set; }
        
        public virtual Store Store { get; set; }
        public virtual Product Product { get; set; }
        public virtual Service Service { get; set; }
        

    }
}
