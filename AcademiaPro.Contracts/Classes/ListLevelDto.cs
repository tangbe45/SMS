using AcademiaPro.Contracts.Classrooms;

namespace AcademiaPro.Contracts.Classes
{
    public class ListLevelDto : LevelDto
    {
        public IEnumerable<ClassroomDto>? Classrooms { get; set; }
    }
}
 