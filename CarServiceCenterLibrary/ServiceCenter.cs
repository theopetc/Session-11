﻿using CarServiceCenterLibrary;

namespace Session_11
{
    public class ServiceCenter
    {
        public List<Customer> Customers { get; set; }
        public List<Car> Cars { get; set; }
        public List<ServiceTask> ServiceTasks { get; set; }
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
            ServiceTasks = new List<ServiceTask>()
            {
                new ServiceTask()
            };
        }
    }
}