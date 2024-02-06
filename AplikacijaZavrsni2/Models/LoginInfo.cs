using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisAplikacija.Models
{
    public class LoginInfo
    {
        public long IDLogin { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public long OIB { get; set; }
        public Worker Worker { get; set; }



    }
}
