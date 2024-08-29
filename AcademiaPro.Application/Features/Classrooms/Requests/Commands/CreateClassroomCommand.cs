using AcademiaPro.Contracts.Classrooms;
using MediatR;

namespace AcademiaPro.Application.Features.Classrooms.Requests.Commands
{
    public class CreateClassroomCommand : IRequest<ClassroomDto>
    {
        public ClassroomDto? ClassroomDto { get; set; }
    }
}
