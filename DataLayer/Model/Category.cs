using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class Category
    {
        [Display(Name="کد دسته")]
        [Key]
        public int Code { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "نام دسته باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name = "نام دسته")]
        public string Name { get; set; }
        [Display(Name = "والد")]
        public int ParentId { get; set; }
        [Display(Name = "نوع دسته")]
        // Store=t or Product Category
        public bool Type { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}