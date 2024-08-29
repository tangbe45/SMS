using AcademiaPro.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaPro.Domain.Entities
{
    public class Level : BaseEntity
    {
        public int LevelId { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Name { get; set; }

        [Range(1, 100)]
        public int SortOrder { get; set; }

        public IEnumerable<Classroom>? Classrooms { get; set; }
    }
}
