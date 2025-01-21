using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Third_Project
{
    internal class PremiumUser : User
    {
        public PremiumUser(string UserName):base(UserName) { }
        
        public override Discount GetDiscount()
        {
            return new FlatDiscount("FlatDiscount ", 100);
        }
    }
}
