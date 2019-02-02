using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.View
{
    class StoreView
    {
        [Display(Name = "کد فروشگاه")]
        public int StoreCode { get; set; }
        
        [Display(Name = "نام فروشگاه")]
        public string Name { get; set; }
        
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        
        [Display(Name = "آدرس")]
        public string Address { get; set; }
        
        [Display(Name = "ایمیل فروشگاه")]
        public string Email { get; set; }
        
        [Display(Name = "شماره فروشگاه")]
        public string Phonenumber { get; set; }

        [Display(Name = "تاریخ ثبت")]
        public string Date { get; set; }

        public int Latitude { get; set; }

        public int Longitude { get; set; }
        
        public int? CategoryCode { get; set; }
        public virtual Category Category { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual ICollection<Gallery> Images { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
