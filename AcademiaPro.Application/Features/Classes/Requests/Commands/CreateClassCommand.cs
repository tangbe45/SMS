using AcademiaPro.Contracts.Classes;
using MediatR;

namespace AcademiaPro.Application.Features.Classes.Requests.Commands
{
    public class CreateClassCommand : IRequest<ListLevelDto>
    {
        public ListLevelDto? Level { get; set; }
    }
}
