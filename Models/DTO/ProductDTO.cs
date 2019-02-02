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
    class ProductDTO
    {
        public int Code { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "نام باید بین 3 تا 50 کاراکتر باشد")]
        public string Name { get; set; }
        [StringLength(100, MinimumLength = 3, ErrorMessage = "توضیحات باید بین 3 تا 50 کاراکتر باشد")]
        public string Description { get; set; }
        public string Date { get; set; }
        [ForeignKey("Category")]
        public int CategoryCode { get; set; }
        //[Display(Name = "فروشگاه")]
        //[ForeignKey("Store")]
        //public int? StoreCode { get; set; }
        //public virtual Store Store { get; set; }
        //public virtual ICollection<Gallery> Images { get; set; }
        //public virtual Category Category { get; set; }
        //public virtual ICollection<Comment> Comments { get; set; }
    }
}
