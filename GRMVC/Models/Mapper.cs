using GRModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRMVC.Models
{
    public class Mapper : IMapper
    {
        public RecordIndexVM cast2RecordIndexVM(Record record2cast)
        {
            return new RecordIndexVM
            {
                RecordName = record2cast.RecordName,
                ArtistName = record2cast.Artist,
                GenreType = record2cast.GenreType,
                ConditionType = record2cast.DaCondition,
                FormatType = record2cast.DaFormat,
                Price = record2cast.Price,
                ID = record2cast.ID
            };
        }
        public Record cast2Record(RecordCRVM record2cast)
        {
            return new Record
            {
                RecordName = record2cast.RecordName,
                Artist = record2cast.ArtistName,
                GenreType = record2cast.GenreType,
                DaCondition = record2cast.ConditionType,
                DaFormat = record2cast.FormatType,
                Price = record2cast.Price,
                ID = record2cast.ID
            };
        }
    }
}
