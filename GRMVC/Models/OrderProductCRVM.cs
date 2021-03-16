using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using GRModels;

namespace GRMVC.Models
{
    public class OrderProductCRVM
    {
        public int ID { get; set; }
        [DisplayName("Record ID")]
        public int RecID { get; set; }
        public Record Record { get; set; }
        public int OrdID { get; set; }
        public Order Order { get; set; }
        [DisplayName("Record Quantity")]
        public int RecQuan { get; set; }
        [DisplayName("Record Quantity")]
        public string RecordName { get; set; }
        [DisplayName("Artist")]
        public string ArtistName { get; set; }
        public Decimal Price { get; set; }
    }
}
