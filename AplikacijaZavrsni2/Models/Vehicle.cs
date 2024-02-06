using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisAplikacija.Models
{
    public class Vehicle
    {

        public int IDVehicle { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public int NumberOfWheels { get; set; }
        public string EngineType { get; set; }
        public int NumberOfDoors { get; set; }
        public string BodyStyle { get; set; }
        public string DriveType { get; set; }
        public ICollection<Service> Services { get; set; } = new List<Service>();
    }


}
