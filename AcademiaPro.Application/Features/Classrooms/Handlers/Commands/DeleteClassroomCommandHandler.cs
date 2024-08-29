using AcademiaPro.Application.Features.Classrooms.Requests.Commands;
using AcademiaPro.Domain.Interfaces.Repositories;
using AutoMapper;
using MediatR;

namespace AcademiaPro.Application.Features.Classrooms.Handlers.Commands
{
    public class DeleteClassroomCommandHandler : IRequestHandler<DeleteClassroomCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteClassroomCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task Handle(DeleteClassroomCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.Classrooms.Delete(request.Id);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
