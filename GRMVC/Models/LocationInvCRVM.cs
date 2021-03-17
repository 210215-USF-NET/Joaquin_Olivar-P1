using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GRModels;

namespace GRMVC.Models
{
    public class LocationInvCRVM
    {
        public int ID { get; set; }
        public int RecID { get; set; }
        public Record Record { get; set; }

        public int LocID { get; set; }
        public Location Location { get; set; }
        public int RecQuan { get; set; }
        public string RecordName { get; set; }
        public Genre GenreType { get; set; }
        public Condition DaCondition { get; set; }

        public Format DaFormat { get; set; }
        public Decimal Price { get; set; }
        public string Artist { get; set; }
        public ICollection<CartProduct> CartProducts { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
        public ICollection<LocationProduct> LocationProducts { get; set; }
    }
}
