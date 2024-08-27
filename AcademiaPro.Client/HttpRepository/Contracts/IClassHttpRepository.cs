using AcademiaPro.Contracts.Classes;

namespace AcademiaPro.Client.HttpRepository.Contracts
{
    public interface IClassHttpRepository
    {
        Task<List<LevelDto>> GetClasses();
        Task<LevelDto> getClass(int id);
        Task<LevelDto> Create(LevelDto levelDto);
        Task Modify(int id, LevelDto levelDto);
    }
}
