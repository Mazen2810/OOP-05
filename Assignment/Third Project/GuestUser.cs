using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Third_Project
{
    internal class GuestUser : User
    {
        public GuestUser(string UserName):base(UserName) { }
       
        public override Discount GetDiscount()
        {
            return new PercentageDiscount("PercentageDiscount", 0);
        }
    }
}
