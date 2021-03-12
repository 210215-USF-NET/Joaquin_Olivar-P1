using GRModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GRDL
{
    public class GRRepoDB : IGRRepo
    {
        private readonly GRDBContext _context;
        public GRRepoDB(GRDBContext context)
        {
            _context = context;
        }
        //Record objects methods
        List<Record> IGRRepo.GetRecords() 
        {
            return _context.Records.AsNoTracking().ToList();
        }
        Record IGRRepo.AddRecord(Record newRecord)
        {
            _context.Records.Add(newRecord);
            _context.SaveChanges();
            return newRecord;
        }
        Record IGRRepo.SearchRecordByName(string name)
        {
            return _context.Records.AsNoTracking().FirstOrDefault(record => record.RecordName == name);
        }
        Record IGRRepo.SearchRecordByID(int RecID)
        {
            return _context.Records.AsNoTracking().FirstOrDefault(record => record.ID == RecID);
        }
     //Order & order products methods
        void IGRRepo.AddOrder(Order order) //In web dev, we shuld have these return the object type
        {
            throw new NotImplementedException();
        }
        List<Order> IGRRepo.GetOrdersByID(int CustomerID)
        {
            return _context.Orders.AsNoTracking().Where(x => x.ID == CustomerID).ToList();
        }
        void IGRRepo.AddOrderProducts(OrderProduct orderProducts)
        {
            throw new NotImplementedException();
        }
        List<OrderProduct> IGRRepo.GetOrderProductsByID(int OrderID)
        {
            throw new NotImplementedException();
        }
     //Customer methods
        List<Customer> IGRRepo.GetCustomers()
        {
            throw new NotImplementedException();
        }
        Customer IGRRepo.AddCustomer(Customer newCustomer)
        {
            _context.Customers.Add(newCustomer);
            _context.SaveChanges();
            return newCustomer;

        }
        Customer IGRRepo.SearchCustomerByFName(string name)
        {
            throw new NotImplementedException();
        }
        Customer IGRRepo.SearchCustomerByID(int CustomerID)
        {
            throw new NotImplementedException();
        }
     //Cart & cart products methods
        Cart IGRRepo.NewCart(int customerID)
        {
            throw new NotImplementedException();
        }
        void IGRRepo.AddToCartProducts(CartProduct cartProducts)
        {
            throw new NotImplementedException();
        }
        List<CartProduct> IGRRepo.GetCartProducts()
        {
            throw new NotImplementedException();
        }
        void IGRRepo.PurgeCartProducts(CartProduct cartProductsforDeletion)
        {
            _context.CartProducts.Remove(cartProductsforDeletion);
            _context.SaveChanges();
        }
     //Inventory methods
        List<Inventory> IGRRepo.GetInventory(int localID)
        {
            throw new NotImplementedException();
        }
        void IGRRepo.AddToInventory(int localID, int RecID, int RecQuan)
        {
            throw new NotImplementedException();
        }
     //Locaton methods
        Location IGRRepo.GetThisLocation(int localID)
        {
            throw new NotImplementedException();
        }
    }
}
