using AcademiaPro.Application.Features.Classes.Requests.Commands;
using AcademiaPro.Domain.Entities;
using AcademiaPro.Domain.Interfaces.Repositories;
using AutoMapper;
using MediatR;

namespace AcademiaPro.Application.Features.Classes.Handlers.Commands
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
            var level = await _unitOfWork.Levels.Get(l => l.LevelId == request.Id);
            if (level == null)
            {
                throw new Exception("This class does not exist");
            }
            if (request.LevelDto == null)
            {
                throw new Exception("Class can not be null");
            }

            _mapper.Map(request.LevelDto, level);
            level.LastModifiedAt = DateTime.UtcNow;

            _unitOfWork.Levels.Update(level);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
