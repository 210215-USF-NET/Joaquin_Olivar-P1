using GRModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRMVC.Models
{
    public class Mapper : IMapper
    {
        //Record methods
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
        public Customer cast2Customer(CustomerCRVM customer2bcast)
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
        public CustomerCRVM cast2CustomerCRVM(Customer customer2bcast)
        {
            return new CustomerCRVM
            {
                FirstName = customer2bcast.FirstName,
                LastName = customer2bcast.LastName,
                Email = customer2bcast.Email,
                Address = customer2bcast.Address,
                ZipCode = customer2bcast.ZipCode
            };
        }
        //Cart & Cart Product methods
        public CartCheckoutVM cast2CartCheckoutVM(CartProduct cartproduct2cast)
        {
            return new CartCheckoutVM
            {
                ID = cartproduct2cast.ID,
                CartID = cartproduct2cast.CartID,
                RecID = cartproduct2cast.RecID,
                RecQuan = cartproduct2cast.RecQuan
            };
        }
        public CartCheckoutVM cast2CartCheckoutVM(CartProduct cartproduct2cast, Record record2cast)
        {
            return new CartCheckoutVM
            {
                ID = cartproduct2cast.ID,
                CartID = cartproduct2cast.CartID,
                RecID = cartproduct2cast.RecID,
                RecQuan = cartproduct2cast.RecQuan,
                RecordName = record2cast.RecordName,
                ArtistName = record2cast.Artist,
                Price = record2cast.Price
            };
        }
        public CartProduct cast2CartProduct(CartCheckoutVM ccvm2cast)
        {
            return new CartProduct
            {
                ID = ccvm2cast.ID,
                CartID = ccvm2cast.CartID,
                RecID = ccvm2cast.RecID,
                RecQuan = ccvm2cast.RecQuan
            };
        }
        public OrderCRVM cast2OrderCRVM(Order order2cast)
        {
            return new OrderCRVM
            {
                ID = order2cast.ID,
                OrDate = order2cast.OrDate,
                TotalCost = order2cast.TotalCost
            };
        }
        public OrderProductCRVM cast2OrderProductCRVM(OrderProduct orderprod2cast, Record record2cast)
        {
            return new OrderProductCRVM
            {
                ID = orderprod2cast.ID,
                RecID = orderprod2cast.RecID,
                RecQuan = orderprod2cast.RecQuan,
                RecordName = record2cast.RecordName,
                ArtistName = record2cast.Artist,
                Price = record2cast.Price
            };
        }
        public LocationInvCRVM cast2LocationInvCRVM(LocationProduct localprod2cast, Record record2cast)
        {
            return new LocationInvCRVM
            {
                ID = localprod2cast.ID,
                LocID = localprod2cast.LocID,
                RecID = localprod2cast.RecID,
                RecQuan = localprod2cast.RecQuan,
                //Actual Record Info
                RecordName = record2cast.RecordName,
                Artist = record2cast.Artist,
                GenreType = record2cast.GenreType,
                DaFormat = record2cast.DaFormat,
                DaCondition = record2cast.DaCondition,
                Price = record2cast.Price
            };
        }

    }
}
