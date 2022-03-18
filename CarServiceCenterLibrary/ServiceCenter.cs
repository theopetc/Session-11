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
        public List<Car> Cars { get; set; }
        public List<Engineer> Engineers { get; set; }
        public ServiceCenter()
        {
            Cars = new List<Car>()
            {
                new Car()
            };
            Customers = new List<Customer>()
            {
                new Customer()
            };
            Engineers = new List<Engineer>()
            {
                new Engineer()
            };
        }
    }
}
