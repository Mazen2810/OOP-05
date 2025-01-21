using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Third_Project
{
    class FlatDiscount : Discount
    {

        public decimal FlatAmount { get; set; }
        public FlatDiscount(string Name, decimal FlatAmount) : base(Name)
        {
            this.FlatAmount = FlatAmount;

        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity <= 1)
                return FlatAmount * quantity;
            else
                return FlatAmount;
        }
    }
}
