using AcademiaPro.Application.Requests.Commands;
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

namespace AcademiaPro.Application.Handlers.Commands
{
    internal class CreateClassCommandHandler : IRequestHandler<CreateClassCommand, LevelDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateClassCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<LevelDto> Handle(CreateClassCommand request, CancellationToken cancellationToken)
        {
            var level = _mapper.Map<Level>(request.Level);
            level.CreatedAt = DateTime.UtcNow;
            level.LastModifiedAt = DateTime.UtcNow;
            _unitOfWork.LevelRepository.Insert(level);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<LevelDto>(level);
        }
    }
}
