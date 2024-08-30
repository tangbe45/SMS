using AcademiaPro.Application.Features.Classrooms.Requests.Commands;
using AcademiaPro.Domain.Entities;
using AcademiaPro.Domain.Interfaces.Repositories;
using AutoMapper;
using MediatR;

namespace AcademiaPro.Application.Features.Classrooms.Handlers.Commands
{
    public class UpdateClassroomCommandHandler : IRequestHandler<UpdateClassroomCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateClassroomCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task Handle(UpdateClassroomCommand request, CancellationToken cancellationToken)
        {
            var classroom = await _unitOfWork.Classrooms.Get(l => l.ClassroomId == request.Id);
            if (classroom == null)
            {
                throw new Exception("This classroom does not exist");
            }

            if (request.ClassroomDto == null)
            {
                throw new Exception("Classroom can not be null");
            }

            _mapper.Map(request.ClassroomDto, classroom);
            classroom.LastModifiedAt = DateTime.UtcNow;

            _unitOfWork.Classrooms.Update(classroom);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
