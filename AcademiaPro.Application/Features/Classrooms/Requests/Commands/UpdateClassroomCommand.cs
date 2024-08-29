using AcademiaPro.Contracts.Classrooms;
using MediatR;

namespace AcademiaPro.Application.Features.Classrooms.Requests.Commands
{
    public class UpdateClassroomCommand : IRequest
    {
        public int Id { get; set; }
        public ClassroomDto? ClassroomDto { get; set; }
    }
}
