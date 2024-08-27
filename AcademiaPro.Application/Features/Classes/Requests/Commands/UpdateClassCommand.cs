using AcademiaPro.Contracts.Classes;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaPro.Application.Features.Classes.Requests.Commands
{
    public class UpdateClassCommand : IRequest
    {
        public int Id { get; set; }
        public LevelDto? LevelDto { get; set; }
    }
}
