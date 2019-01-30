using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Model
{
    public class Store
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "کد فروشگاه")]
        [Key]
        public int StoreCode { get; set; }
        [StringLength(50,MinimumLength =3,ErrorMessage ="نام باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name="نام فروشگاه")]
        public string Name { get; set; }
        [StringLength(100, MinimumLength = 3, ErrorMessage = "توضیحات باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "نام دسته باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name = "دسته بندی")]
        public string Category { get; set; }
        [StringLength(70, MinimumLength = 3, ErrorMessage = "آدرس باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name = "آدرس")]
        public string Address { get; set; }
        [EmailAddress(ErrorMessage ="ایمیل وارد شده نامعتبر است")]
        [Display(Name = "ایمیل فروشگاه")]
        public string Email { get; set; }
        [StringLength(11, MinimumLength = 3, ErrorMessage = "شماره باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name = "شماره فروشگاه")]
        public string Phonenumber { get; set; }
        [Display(Name="تاریخ")]
        public string Date { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual Gallery Image { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }





    }
}