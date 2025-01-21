using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Third_Project
{
    class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount(string Name) : base(Name) { }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity > 1)
                return (price / 2) * (quantity / 2);
            else
                return 0;
        }

        
    }
}
