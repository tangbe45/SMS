using System.ComponentModel.DataAnnotations;
using AcademiaPro.Contracts.Classes;

namespace AcademiaPro.Contracts.Classrooms
{
    public class ClassroomDto
    {
        public int ClassroomId { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Name { get; set; }

        [Required]
        public int Capacity { get; set; }

        public int StudentCount { get; set; }

        [Range(1, 100)]
        public int SortOrder { get; set; }

        public LevelDto? LevelDto { get; set; }

        public int LevelId { get; set; }
    }
}
