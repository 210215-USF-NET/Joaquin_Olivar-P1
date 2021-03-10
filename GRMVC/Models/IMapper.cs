using GRModels;

namespace GRMVC.Models
{
    public interface IMapper
    {
        RecordIndexVM cast2RecordIndexVM(Record record2cast);
    }
}