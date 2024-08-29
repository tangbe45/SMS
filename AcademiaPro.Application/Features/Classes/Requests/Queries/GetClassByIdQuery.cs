using AcademiaPro.Contracts.Classes;
using AcademiaPro.Contracts.Classrooms;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaPro.Application.Features.Classes.Requests.Queries
{
    public struct GetClassByIdQuery : IRequest<LevelDto>
    {
        public int Id { get; set; }
    }
}
