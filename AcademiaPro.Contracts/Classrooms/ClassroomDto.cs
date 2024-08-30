using AcademiaPro.Contracts.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        [Range(1, 100)]
        public int SortOrder { get; set; }

        public int LevelId { get; set; }
    }
}
