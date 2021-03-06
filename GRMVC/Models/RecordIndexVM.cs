using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using GRModels;

namespace GRMVC.Models
{
    public class RecordIndexVM
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
        public decimal Price { get; set; }
        public int ID { get; set; }
    }
}
