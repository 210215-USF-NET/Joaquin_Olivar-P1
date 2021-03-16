using System;
using System.Collections.Generic;
using GRModels;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GRMVC.Models
{
    public class OrderCRVM
    {
        public int ID { get; set; }
        public int CartID { get; set; }
        public int LocalID { get; set; }
        public Location Location { get; set; }
        [DisplayName("Order Date")]
        public DateTime OrDate { get; set; }
        public Customer Customer { get; set; }
        public int CusID { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
        public Decimal TotalCost { get; set; }
    }
}
