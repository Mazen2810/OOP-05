using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Third_Project
{
    abstract class Discount
    {
        public string? Name { get; set; }
        protected Discount(string Name)
        {
            this.Name = Name;
        }
        public abstract decimal CalculateDiscount(decimal price, int quantity);
    }
}

