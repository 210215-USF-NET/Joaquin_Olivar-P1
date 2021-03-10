using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GRModels;

namespace GRMVC.Models
{
    public class RecordIndexVM
    {
        public string RecordName { get; set; }
        public string ArtistName { get; set; }
        public Genre GenreType { get; set; }
        public Condition ConditionType { get; set; }
        public Format FormatType { get; set; }
        public decimal Price { get; set; }
        public int ID { get; set; }
    }
}
