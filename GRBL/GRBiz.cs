using GRModels;
using System.Collections.Generic;
using GRDL;
namespace GRBL
{
    public class GRBiz : IGRBiz
    {
        private IGRRepo _repo;
        public GRBiz(IGRRepo repo)
        {
            _repo = repo;
        }
        //Record object methods
            Record IGRBiz.AddRecord(Record newRecord)
            {
                return _repo.AddRecord(newRecord);
            }
            public List<Record> GetRecords()
            {
                return _repo.GetRecords();
            }
            public Record SearchRecordByName(string name)
            {
                return _repo.SearchRecordByName(name);
            }
            public Record SearchRecordByID(int RecID)
            {
                return _repo.SearchRecordByID(RecID);
            }
        //Order & Order Products methods
            public void AddOrder(Order order)
            {
                _repo.AddOrder(order);
            }
            public List<Order> GetOrdersByID(int CustomerID)
            {
                return _repo.GetOrdersByID(CustomerID);
            }
            public void addOrderProducts(OrderProduct newOrderProducts)
            {
                _repo.AddOrderProducts(newOrderProducts);
            }
            public List<OrderProduct> GetOrderProductsByID(int OrderID)
            {
                return _repo.GetOrderProductsByID(OrderID);
            }
        //Customer methods
            public void AddCustomer(Customer newCustomer)
            {
                _repo.AddCustomer(newCustomer);
            }
            public List<Customer> GetCustomers()
            {
                return _repo.GetCustomers();
            }
            public Customer SearchCustomerByFName(string name)
            {
                return _repo.SearchCustomerByFName(name);
            }
            public Customer SearchCustomerByID(int CustomerID)
            {
                return _repo.SearchCustomerByID(CustomerID);
            }
            public Customer GetCustomerByEmail(string email)
            {
                return _repo.GetCustomerByEmail(email);
            }
         //Cart & cart product methods
            public Cart newCart(int customerID)
            {
                return _repo.NewCart(customerID);
            }
            public void AddToCartProducts(CartProduct cartProducts)
            {
                _repo.AddToCartProducts(cartProducts);
            }
            public List<CartProduct> GetCartProducts()
            {
                return _repo.GetCartProducts();
            }
            public void PurgeCartProducts(CartProduct cartProductsforDeletion)
            {
                _repo.PurgeCartProducts(cartProductsforDeletion);
            }
        //Inventory methods
            public List<Inventory> GetInventory(int localID)
            {
                return _repo.GetInventory(localID);
            }
            public void AddToInventory(int localID, int RecID, int RecQuan)
            {
                _repo.AddToInventory(localID, RecID, RecQuan);
            }
        //Location methods
        public Location GetThisLocation(int localID)
        {
            return _repo.GetThisLocation(localID);
        }
    }
}