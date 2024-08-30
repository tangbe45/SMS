using AcademiaPro.Contracts.Classes;

namespace AcademiaPro.Client.HttpRepository.Contracts
{
    public interface IClassHttpRepository
    {
        Task<List<ListLevelDto>> GetClasses();
        Task<ListLevelDto> getClass(int id);
        Task<ListLevelDto> Create(ListLevelDto levelDto);
        Task Modify(int id, ListLevelDto levelDto);
        Task Delete(int id);
    }
}
