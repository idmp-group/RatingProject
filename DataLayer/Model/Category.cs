using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name="کد دسته")]
        [Key]
        public int Code { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "نام دسته باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name = "نام دسته")]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}