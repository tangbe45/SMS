using AcademiaPro.Application.Features.Classrooms.Requests.Commands;
using AcademiaPro.Contracts.Classrooms;
using AcademiaPro.Domain.Entities;
using AcademiaPro.Domain.Interfaces.Repositories;
using AutoMapper;
using MediatR;


namespace AcademiaPro.Application.Features.Classrooms.Handlers.Commands
{
    internal class CreateClassroomCommandHandler : IRequestHandler<CreateClassroomCommand, ClassroomDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateClassroomCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ClassroomDto> Handle(CreateClassroomCommand request, CancellationToken cancellationToken)
        {
            var classroom = _mapper.Map<Classroom>(request.ClassroomDto);
            classroom.CreatedAt = DateTime.UtcNow;
            classroom.LastModifiedAt = DateTime.UtcNow;
            await _unitOfWork.Classrooms.Create (classroom);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<ClassroomDto>(classroom);
        }
    }
}
