using GRModels;

namespace GRMVC.Models
{
    public interface IMapper
    {
        //Record Methods
        Record cast2Record(RecordCRVM record2cast);
        RecordIndexVM cast2RecordIndexVM(Record record2cast);
        RecordCRVM cast2RecordCRVM(Record record2cast);
        //Customer Methods
        Customer cast2Customer(CustomerCRVM customer2bcast);
        //Cart Methods
        CartCheckoutVM cast2CartCheckoutVM(CartProduct cartproduct2cast); //Cart Product Only
        CartCheckoutVM cast2CartCheckoutVM(CartProduct cartproduct2cast, Record record2cast); //Cart + Record info
        //Customer Methods
        CustomerCRVM cast2CustomerCRVM(Customer customer2bcast);
        CartProduct cast2CartProduct(CartCheckoutVM ccvm2cast);
        //Order Methods
        OrderCRVM cast2OrderCRVM(Order order2cast);
        OrderProductCRVM cast2OrderProductCRVM(OrderProduct orderprod2cast, Record record2cast); //Order product + Record info
        
    }
}