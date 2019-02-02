using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Base
{
    public class EntityBase
    {
        public EntityBase()
        {
            UpdateDate = DateTime.Now;
        }

        [Key]
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
