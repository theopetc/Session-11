﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenterLibrary
{
    public class ServiceTask
    {
        public Guid ID { get; set; }
        public int Code { get; set; }//Dictionary enum 
        public string Description { get; set; }
        public decimal Hours { get; set; }


        public ServiceTask(int code, string description, decimal hours)
        {
            ID = Guid.NewGuid();
            Code = code;
            Description = description;
            Hours = hours;
        }
    }
}
