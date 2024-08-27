using AcademiaPro.Application.Features.Classes.Requests.Commands;
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
    public class DeleteClassCommandHandler : IRequestHandler<DeleteClassCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteClassCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task Handle(DeleteClassCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.Levels.Delete(request.Id);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
