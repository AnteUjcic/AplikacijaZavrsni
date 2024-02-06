using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServisAplikacija.Models
{
    public class Worker
    {
        public long OIB { get; set; }
        public string WorkerName { get; set; }
        public string WorkerSurname { get; set; }
        public LoginInfo LoginInfo { get; set; }
        public ICollection<Service> Services { get; set; } = new List<Service>();


    }
}
