using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ViewModel
{
    public class StoreOwner
    {
        public virtual Owner Owner { get; set; }
        public virtual Store Store { get; set; }
    }
}
