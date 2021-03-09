namespace GRModels
{
    public class Cart
    {
        public int ID {get; set;}
        public int CustomerID {get; set;}
        public override string ToString() => $"Cart Details: \n\t CartID: {this.ID} \n\t CustomerID: {this.CustomerID}";
    }
}