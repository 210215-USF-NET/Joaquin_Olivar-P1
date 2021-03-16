using System;
using System.Collections.Generic;
namespace GRModels
{
    public class Order
    {
        public int ID {get; set;}
        public int CartID {get; set;}
        public int LocalID {get; set;}
        public Location Location { get; set; }
        public DateTime OrDate {get; set;}
        public Customer Customer {get; set;}
        public int CusID {get; set;}
        public ICollection<OrderProduct> OrderProducts { get; set; }
        public Decimal TotalCost { get; set; }

        public override string ToString() => $"\tOrder Number: {ID}\n\tOrder Date: {OrDate}";
    }
}