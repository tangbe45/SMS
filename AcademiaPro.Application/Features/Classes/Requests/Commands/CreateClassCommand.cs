using AcademiaPro.Contracts.Classes;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaPro.Application.Features.Classes.Requests.Commands
{
    public class CreateClassCommand : IRequest<LevelDto>
    {
        public LevelDto? Level { get; set; }
    }
}
