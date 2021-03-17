namespace GRModels
{
    public class CartProduct
    {
        public int ID { get; set; }
        public int CartID { get; set; }
        public Cart Cart { get; set; }

        public int RecID { get; set; }
        public Record Record { get; set; }
        public int RecQuan { get; set; }

    }
}