using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class StoreDTO
    {
        public int Code { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "نام باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name = "نام فروشگاه")]
        public string Name { get; set; }
        [Required]

        [StringLength(100, MinimumLength = 3, ErrorMessage = "توضیحات باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        [Required]

        [StringLength(70, MinimumLength = 3, ErrorMessage = "آدرس باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name = "آدرس")]
        public string Address { get; set; }
        [Required]

        [EmailAddress(ErrorMessage = "ایمیل وارد شده نامعتبر است")]
        [Display(Name = "ایمیل فروشگاه")]
        public string Email { get; set; }
        [Required]

        [StringLength(11, MinimumLength = 3, ErrorMessage = "شماره باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name = "شماره فروشگاه")]
        public string Phonenumber { get; set; }

        [Required]

        public int Latitude { get; set; }
        [Required]

        public int Longitude { get; set; }
        [Display(Name = "دسته بندی")]
        [ForeignKey("Category")]
        public int? CategoryCode { get; set; }
        public virtual Category Category { get; set; }
        public virtual Owner Owner { get; set; }
        //public virtual ICollection<Gallery> Images { get; set; }
        //public virtual ICollection<Product> Products { get; set; }
        //public virtual ICollection<Service> Services { get; set; }
        //public virtual ICollection<Comment> Comments { get; set; }
    }
}
