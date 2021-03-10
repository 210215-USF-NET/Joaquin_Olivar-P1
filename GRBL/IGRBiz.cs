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
        void AddOrder(Order order);
        List<Order> GetOrdersByID(int CustomerID);
        void addOrderProducts(OrderProduct newOrderProducts);
        List<OrderProduct> GetOrderProductsByID(int OrderID);
    //Customer methods
        List<Customer> GetCustomers();
        void AddCustomer(Customer newCustomer);
        Customer SearchCustomerByFName(string name);
        Customer SearchCustomerByID(int CustomerID);
    //Cart & cart product methods
        Cart newCart(int customerID);  
        void AddToCartProducts(CartProduct cartProducts);
        List<CartProduct> GetCartProducts();
        void PurgeCartProducts(CartProduct cartProductsforDeletion);
    //Inventory methods
        List<Inventory> GetInventory(int localID);
        void AddToInventory(int localID, int RecID, int RecQuan);
    //Location methods
        Location GetThisLocation(int localID);
    }
}