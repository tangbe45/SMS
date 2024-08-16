using AcademiaPro.Contracts.Classes;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaPro.Application.Requests.Queries
{
    public class GetClassesQuery : IRequest<IEnumerable<LevelDto>>
    {
    }
}
