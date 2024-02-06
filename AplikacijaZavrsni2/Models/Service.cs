using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisAplikacija.Models
{
    public class Service
    {

        public string ServiceType { get; set; }
        public DateOnly DateOfservice { get; set; }
        public double KMService { get; set; }
        public double NextKMService { get; set; }

        public long OIB { get; set; }
        public Worker Worker { get; set; }

        public int IDVehicle { get; set; } 
        public Vehicle Vehicle { get; set; }


    }
}
