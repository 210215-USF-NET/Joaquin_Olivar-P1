using GRModels;

namespace GRMVC.Models
{
    public interface IMapper
    {
        Record cast2Record(RecordCRVM record2cast);
        RecordIndexVM cast2RecordIndexVM(Record record2cast);
        Customer cast2CustomerCRVM(CustomerCRVM customer2bcast);
    }
}