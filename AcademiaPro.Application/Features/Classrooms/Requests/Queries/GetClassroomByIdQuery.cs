using AcademiaPro.Contracts.Classrooms;
using MediatR;

namespace AcademiaPro.Application.Features.Classrooms.Requests.Queries
{
    public struct GetClassroomByIdQuery : IRequest<ClassroomDto>
    {
        public int Id { get; set; }
    }
}
