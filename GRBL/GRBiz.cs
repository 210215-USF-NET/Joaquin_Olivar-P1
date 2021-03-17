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
            public Order AddOrder(int CartID, int CusID, decimal Total)
            {
                return _repo.AddOrder(CartID, CusID, Total);
            }
            public List<Order> GetOrdersByID(int CustomerID)
            {
                return _repo.GetOrdersByID(CustomerID);
            }
            public OrderProduct AddOrderProduct(int OrdID, int RecID, int RecQuan)
            {
                return _repo.AddOrderProduct(OrdID, RecID, RecQuan);
            }
            public List<OrderProduct> GetOrderProductsByID(int OrderID)
            {
                return _repo.GetOrderProductsByID(OrderID);
            }
        //Customer methods
            public Customer AddCustomer(Customer newCustomer)
            {
                return _repo.AddCustomer(newCustomer);
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
            public Cart GetCartByCustomer(int customerID)
            {
                return _repo.GetCartByCustomer(customerID);
            }
            CartProduct IGRBiz.AddToCartProducts(int RecID, int Quan, int CartID)
            {
                return _repo.AddToCartProducts(RecID, Quan, CartID);
            }
            public List<CartProduct> GetCartProducts()
            {
                return _repo.GetCartProducts();
            }
            CartProduct IGRBiz.GetCartProductByID(int ID)
            {
                return _repo.GetCartProductByID(ID);
            }
             public List<CartProduct> GetCartProductsByCartID(int ID)
            {
                return _repo.GetCartProductsByCartID(ID);
            }
            public CartProduct PurgeCartProduct(CartProduct cartProductsforDeletion)
                {
                    return _repo.PurgeCartProduct(cartProductsforDeletion);
                }
            //Location and location product methods
            public List<LocationProduct> GetLocationProducts(int localID)
            {
                return _repo.GetLocationProducts(localID);
            }
            public LocationProduct AddLocationProduct(int localID, int RecID, int RecQuan)
            {
                return _repo.AddLocationProduct(localID, RecID, RecQuan);
            }

        public Location GetThisLocation(int localID)
        {
            return _repo.GetThisLocation(localID);
        }
    }
}