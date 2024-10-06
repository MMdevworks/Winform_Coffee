using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_4
{
    public abstract class Beverage
    {
        public Guid OrderId { get; set; }
        public string Name { get; set; }
        public string Customer { get; set; }
        public decimal OrderTotal { get; set; }
    }
}
