using GRModels;

namespace GRMVC.Models
{
    public interface IMapper
    {
        //Record Methods
        Record cast2Record(RecordCRVM record2cast);
        RecordIndexVM cast2RecordIndexVM(Record record2cast);
        RecordCRVM cast2RecordCRVM(Record record2cast);
        Customer cast2CustomerCRVM(CustomerCRVM customer2bcast);
        CartCheckoutVM cast2CartCheckoutVM(CartProduct cartproduct2cast);
        
    }
}