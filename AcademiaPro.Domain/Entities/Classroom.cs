using AcademiaPro.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademiaPro.Domain.Entities
{
    public class Classroom : BaseEntity
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

        public Level? Level { get; set; }
        public int LevelId { get; set; }
    }
}
