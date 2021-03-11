using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GRModels;

namespace GRMVC.Models
{
    public class RecordCRVM
    {
        [DisplayName("Record")]
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
        public decimal Price { get; set; }
        [Range(1000,Int32.MaxValue, ErrorMessage = "ID values start at 1000.")]
        public int ID { get; set; }
    }
}
