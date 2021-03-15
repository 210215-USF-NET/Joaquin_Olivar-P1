using System;
using System.Collections.Generic;
namespace GRModels
{
    public class Record
    {
        public int ID { get; set; }
        private string recordName;

        public string RecordName{
            get {return recordName;}
            set{
                //if (value.Equals(null)){
                //    throw new ArgumentNullException("Record must have a name.");
                //}
                recordName = value;
            }
        }

        public Genre GenreType{get; set;}
        public Condition DaCondition{get; set;}

        public Format DaFormat{get; set;}
        public Decimal Price {get; set;}
        public string Artist{get;set;}
        public ICollection<CartProduct> CartProducts { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
        public ICollection<LocationProduct> LocationProducts { get; set; }

        public override string ToString() => $"{this.DaCondition} {this.DaFormat}: \n\t Album Name: {this.RecordName} \n\t Artist: {this.Artist} \n\t Genre: {this.GenreType} \n\t Price: ${this.Price} \n\t ID: {this.ID}";

    }
}
