using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GRModels;
using GRBL;

namespace GRMVC.Models
{
    public class CartCheckoutVM
    {
        //Cart Product Values
        public int ID { get; set; }
        public int CartID { get; set; }
        [DisplayName("Record ID")]
        public int RecID { get; set; }
        [DisplayName("Quantity")]
        public int RecQuan { get; set; }
        [DisplayName("Record")]
        //Record information
        public string RecordName { get; set; }
        [DisplayName("Artist")]
        public string ArtistName { get; set; }
        [DisplayName("Genre")]
        public Genre GenreType { get; set; }
        [DisplayName("Condition")]
        public Condition ConditionType { get; set; }
        [DisplayName("Format")]
        public Format FormatType { get; set; }
        [Range(1, 9999.99, ErrorMessage = "Prices can't be negative.")]
        public Decimal Price { get; set; }
       
    }
}
