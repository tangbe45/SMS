using AcademiaPro.Application.Requests.Commands;
using AcademiaPro.Domain.Interfaces.Repositories;
using AutoMapper;
using MediatR;

namespace AcademiaPro.Application.Handlers.Commands
{
    public class UpdateClassCommandHandler : IRequestHandler<UpdateClassCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateClassCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task Handle(UpdateClassCommand request, CancellationToken cancellationToken)
        {
            var level = await _unitOfWork.LevelRepository.GetById(request.Id);
            if(level == null)
            {
                throw new Exception("The class does not exist");
            }
            if(request.LevelDto == null)
            {
                throw new Exception("Class is null");
            }

            level.LastModifiedAt = DateTime.UtcNow;
            level.Name = request.LevelDto.Name;
            level.SortOrder = request.LevelDto.SortOrder;

            await _unitOfWork.SaveChangesAsync();
        }
    }
}
