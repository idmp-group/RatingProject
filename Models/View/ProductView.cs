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
    class ProductView
    {
        [Display(Name = "کد محصول")]
        public int Code { get; set; }
        [Display(Name = "نام محصول")]
        public string Name { get; set; }
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        [Display(Name = "تاریخ ثبت")]
        public string Date { get; set; }
        [ForeignKey("Category")]
        [Display(Name = "دسته بندی")]
        public int CategoryCode { get; set; }
        [Display(Name = "فروشگاه")]
        [ForeignKey("Store")]
        public int? StoreCode { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<Gallery> Images { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
