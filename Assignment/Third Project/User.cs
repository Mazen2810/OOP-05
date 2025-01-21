using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Third_Project
{
    abstract class User
    {
        public string?  UserName { get; set; }

        protected User(string UserName)
        {
            this.UserName = UserName;
        }

        public abstract Discount GetDiscount();
    }
}
