using AcademiaPro.Application.Features.Classrooms.Requests.Queries;
using AcademiaPro.Contracts.Classrooms;
using AcademiaPro.Domain.Interfaces.Repositories;
using AutoMapper;
using MediatR;

namespace AcademiaPro.Application.Features.Classrooms.Handlers.Queries
{
    public class GetClassroomByIdQueryHandler : IRequestHandler<GetClassroomByIdQuery, ClassroomDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetClassroomByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ClassroomDto> Handle(GetClassroomByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Classrooms.Get(l => l.ClassroomId == request.Id);
            return _mapper.Map<ClassroomDto>(result);
        }
    }
}
