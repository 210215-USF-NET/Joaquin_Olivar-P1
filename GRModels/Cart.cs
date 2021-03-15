using System.Collections.Generic;
namespace GRModels
{
    public class Cart
    {
        public int ID {get; set;}
        public int CustomerID {get; set;}
        public Customer Customer { get; set; }
        public ICollection<CartProduct> CartProducts { get; set; }
        public int localID { get; set; }
        public Location Location { get; set; }
        public override string ToString() => $"Cart Details: \n\t CartID: {this.ID} \n\t CustomerID: {this.CustomerID}";
    }
}