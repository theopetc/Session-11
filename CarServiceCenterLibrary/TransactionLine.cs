using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenterLibrary
{
    public class TransactionLine
    {
        public Guid ID { get; set; }
        public Guid TransactionID { get; set; }
        public Guid ServiceTaskID { get; set; }
        public Guid EngineerID { get; set; }
        public decimal Hours { get; set; }
        public const decimal PRICE_PER_HOUR = 44.5m;
        public decimal Price { get; set; }//hours*priceperhour?

        public TransactionLine()
        {
            
        }
    }
}
