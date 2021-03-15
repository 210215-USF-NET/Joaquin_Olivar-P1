using GRModels;
using System.Collections.Generic;
namespace GRBL
{
    public interface IGRBiz
    {
        //Record object methods
        List<Record> GetRecords();
        Record AddRecord(Record newRecord);
        Record SearchRecordByName(string name);
        Record SearchRecordByID (int RecID);
    //Order & Order Products methods
        Order AddOrder(int CartID, int CusID);
        List<Order> GetOrdersByID(int CustomerID);
        OrderProduct AddOrderProduct(int OrdID, int RecID, int RecQuan);
        List<OrderProduct> GetOrderProductsByID(int OrderID);
    //Customer methods
        List<Customer> GetCustomers();
        Customer AddCustomer(Customer newCustomer);
        Customer SearchCustomerByFName(string name);
        Customer SearchCustomerByID(int CustomerID);
        Customer GetCustomerByEmail(string email);
    //Cart & cart product methods
        Cart newCart(int customerID);
        Cart GetCartByCustomer(int customerID);
        CartProduct AddToCartProducts(int RecID, int Quan, int CartID);
        List<CartProduct> GetCartProducts();
        CartProduct GetCartProductByID(int ID);
        List<CartProduct> GetCartProductsByCartID(int ID);
        CartProduct PurgeCartProduct(CartProduct cartProductsforDeletion);
    //Inventory methods
        List<LocationProduct> GetInventory(int localID);
        void AddToInventory(int localID, int RecID, int RecQuan);
    //Location methods
        Location GetThisLocation(int localID);
    }
}