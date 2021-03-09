namespace GRModels
{
    public class OrderProduct
    {
        public int ID {get; set;}
        public int RecID {get; set;}
        public int OrdID {get; set;}
        public int RecQuan {get; set;}
        public override string ToString() => $"\tRecord#:{RecID}\n\tQuantity:{RecQuan}";
    }
}