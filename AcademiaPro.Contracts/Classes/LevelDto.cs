using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaPro.Contracts.Classes
{
    public class LevelDto
    {
        [Required]
        [MaxLength(20)]
        public string? Name { get; set; }

        [Range(1, 100)]
        public int SortOrder { get; set; }

    }
}
