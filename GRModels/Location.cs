using System.Collections.Generic;
namespace GRModels
{
    public class Location
    {
        public int ID { get; set; }
        public string localName { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<LocationProduct> LocationProducts { get; set; }
        

    }
}