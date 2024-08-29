using AcademiaPro.Contracts.Classes;
using MediatR;

namespace AcademiaPro.Application.Features.Classes.Requests.Commands
{
    public class CreateClassCommand : IRequest<LevelDto>
    {
        public LevelDto? Level { get; set; }
    }
}
