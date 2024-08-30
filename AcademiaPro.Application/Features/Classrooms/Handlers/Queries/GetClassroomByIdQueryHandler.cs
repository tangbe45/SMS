using AcademiaPro.Application.Features.Classrooms.Requests.Queries;
using AcademiaPro.Contracts.Classes;
using AcademiaPro.Contracts.Classrooms;
using AcademiaPro.Domain.Entities;
using AcademiaPro.Domain.Interfaces.Repositories;
using AutoMapper;
using MediatR;

namespace AcademiaPro.Application.Features.Classrooms.Handlers.Queries
{
    public class GetClassroomByIdQueryHandler : IRequestHandler<GetClassroomByIdQuery, ListClassroomDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetClassroomByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ListClassroomDto> Handle(GetClassroomByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Classrooms.Get(l => l.ClassroomId == request.Id, new List<string> { "Level" });
             var classroomDto = _mapper.Map<ListClassroomDto>(result);
            return classroomDto;
        }
    }
}
