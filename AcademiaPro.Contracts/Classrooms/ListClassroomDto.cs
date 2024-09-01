using System.ComponentModel.DataAnnotations;
using AcademiaPro.Contracts.Classes;

namespace AcademiaPro.Contracts.Classrooms
{
    public class ListClassroomDto : ClassroomDto
    {
        public int StudentCount { get; set; }

        public LevelDto Level { get; set; }
    }
}
