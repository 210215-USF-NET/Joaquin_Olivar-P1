using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GRMVC.Models
{
    public class CartCheckoutVM
    {
        //Cart Product Values
        public int ID { get; set; }
        public int CartID { get; set; }
        [DisplayName("Record ID")]
        public int RecID { get; set; }
        [DisplayName("Quantity")]
        public int RecQuan { get; set; }
    }
}
