using AcademiaPro.Application.Features.Classes.Requests.Commands;
using AcademiaPro.Contracts.Classes;
using AcademiaPro.Domain.Entities;
using AcademiaPro.Domain.Interfaces.Repositories;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaPro.Application.Features.Classes.Handlers.Commands
{
    internal class CreateClassCommandHandler : IRequestHandler<CreateClassCommand, ListLevelDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateClassCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ListLevelDto> Handle(CreateClassCommand request, CancellationToken cancellationToken)
        {
            var level = _mapper.Map<Level>(request.Level);
            level.CreatedAt = DateTime.UtcNow;
            level.LastModifiedAt = DateTime.UtcNow;
            await _unitOfWork.Levels.Create (level);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<ListLevelDto>(level);
        }
    }
}
