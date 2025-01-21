using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Third_Project
{
    class PercentageDiscount : Discount
    {
        public decimal percentage { get; set; }
        public PercentageDiscount( string Name, decimal percentage) : base(Name)
        {
            this.percentage = percentage;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (percentage / 100);
        }
    }
}
