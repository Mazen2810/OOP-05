using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Third_Project
{
    class RegularUser : User
    {
        public RegularUser(string UserName) : base(UserName) { }
        
        public override Discount GetDiscount()
        {
            return new PercentageDiscount("PercentageDiscount " , 5);
        }
    }
}
