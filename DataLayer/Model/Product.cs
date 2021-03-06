﻿using DataLayer.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Model
{
    [Table("Products",Schema ="PDC")]
    public class Product
    {
        [Key]
        public int Code { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        public string Date { get; set; }
        
        public int CategoryCode { get; set; }
        
        public int? StoreCode { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<Gallery> Images { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

    }
}
