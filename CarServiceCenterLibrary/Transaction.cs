using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenterLibrary
{
    public class Transaction
    {
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public Guid CustomerID { get; set; }
        public Guid CarID { get; set; }
        public Guid ManagerID { get; set; }
        public decimal TotalPrice { get; set; }
        public Transaction(Guid customerID, Guid carID, Guid managerID)
        {            
            ID = Guid.NewGuid();
            Date = DateTime.Now;
            CustomerID = customerID;
            CarID = carID;
            ManagerID = managerID;
        }
    }
}
