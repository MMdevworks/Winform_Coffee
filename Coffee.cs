using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Assignment3_4
{  
    public enum BagSize { [Description("8 oz")] _8oz, [Description("12 oz")] _12oz, [Description("16 oz")] _16oz, [Description("32 oz")] _32oz }
    
    public class Coffee : Beverage
    {
        public int BagCount { get; set; }
        public BagSize BagSize { get; set; }
        public double CoffeeBulkPrice(int bags, int bagsize)
           {
            double total;
            switch(bagsize)
            {
                case 0:
                    total = bags * 9.99;
                    break;
                case 1:
                    total = bags * 13.99;
                    break;
                case 2:
                    total = bags * 17.99;
                    break;
                case 3:
                    total = bags * 19.99;
                    break;
                case 4:
                    total = bags * 22.99;
                    break;
                default:
                    total = 0;
                    break;
            }
            return total;
        }
    }

}
