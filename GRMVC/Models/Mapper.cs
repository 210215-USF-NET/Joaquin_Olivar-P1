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
            //Record mapper methods
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
        public RecordCRVM cast2RecordCRVM(Record record2cast)
        {
            return new RecordCRVM
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
        //Customer methods
        public Customer cast2CustomerCRVM(CustomerCRVM customer2bcast)
        {
            return new Customer
            {
                FirstName = customer2bcast.FirstName,
                LastName = customer2bcast.LastName,
                Email = customer2bcast.Email,
                Address = customer2bcast.Address,
                ZipCode = customer2bcast.ZipCode
            };
        }

        public CartCheckoutVM cast2CartCheckoutVM(CartProduct cartproduct2cast)
        {
            return new CartCheckoutVM
            {
                ID = cartproduct2cast.ID,
                CartID = cartproduct2cast.CartID,
                RecID = cartproduct2cast.RecID,
                RecQuan = cartproduct2cast.RecQuan,
                RecordName = cartproduct2cast.Record.RecordName
            };

        }
    }
}
