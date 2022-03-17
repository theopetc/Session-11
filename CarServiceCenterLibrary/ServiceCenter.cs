using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenterLibrary
{
    public class ServiceCenter
    {
        public List<Customer> Customers { get; set; }
        public List<Engineer> Engineers { get; set; }   
        public ServiceCenter()
        {
            Customers = new List<Customer>();
            Engineers = new List<Engineer>();  
        }
    }
}
