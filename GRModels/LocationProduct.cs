namespace GRModels
{
    public class LocationProduct
    {
        public int ID { get; set; }
        public int RecID { get; set; }
        public Record Record { get; set; }
        public Location Location { get; set; }
        public int LocID {get; set;}
        public int RecQuan {get; set;}
    }
}