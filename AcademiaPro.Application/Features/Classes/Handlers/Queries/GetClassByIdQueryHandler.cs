using AcademiaPro.Application.Features.Classes.Requests.Queries;
using AcademiaPro.Contracts.Classes;
using AcademiaPro.Domain.Interfaces.Repositories;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaPro.Application.Features.Classes.Handlers.Queries
{
    public class GetClassByIdQueryHandler : IRequestHandler<GetClassByIdQuery, ListLevelDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetClassByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ListLevelDto> Handle(GetClassByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Levels.Get(l => l.LevelId == request.Id);
            return _mapper.Map<ListLevelDto>(result);
        }
    }
}
