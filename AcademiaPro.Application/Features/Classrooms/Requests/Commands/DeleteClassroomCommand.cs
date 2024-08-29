using MediatR;

namespace AcademiaPro.Application.Features.Classrooms.Requests.Commands
{
    public class DeleteClassroomCommand : IRequest
    {
        public int Id { get; set; }
    }
}
