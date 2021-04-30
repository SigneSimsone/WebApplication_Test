using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Test.Models
{
    public class PrivacyModel
    {
        public string User;
        public bool IsAdmin()
        {
            if(User == "Admin")
            {
                return true;
            }
            return false;
        }
    }
}
