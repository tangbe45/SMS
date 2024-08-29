using AcademiaPro.Contracts.Classrooms;
using MediatR;

namespace AcademiaPro.Application.Features.Classrooms.Requests.Queries
{
    public class GetClassroomsQuery : IRequest<IEnumerable<ClassroomDto>>
    {
    }
}
