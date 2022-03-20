using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenterLibrary
{
    [Serializable]
    
    public class Transaction
    {
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public Guid CustomerID { get; set; }
        public Guid CarID { get; set; }
        public Guid ManagerID { get; set; }
        public decimal TotalPrice { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }
<<<<<<< HEAD
        public Transaction()
        {            
            ID = Guid.NewGuid();
            Date = DateTime.Now;
        }
        public Transaction(Guid customerID, Guid carID, Guid managerID, DateTime date)
        {
            ID = Guid.NewGuid();
=======
        public Transaction(Guid customerID, Guid carID, Guid managerID, DateTime date)
        {   
            ID = Guid.NewGuid();
>>>>>>> 603a9feaa1237e266ddc966af05ff3d5b5d5d6d6
            Date = date;
            CustomerID = customerID;
            CarID = carID;
            ManagerID = managerID;
            TransactionLines = new List<TransactionLine>();
        }
    }
}
