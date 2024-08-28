﻿using AcademiaPro.Application.Features.Classes.Requests.Queries;
using AcademiaPro.Contracts.Classes;
using AcademiaPro.Domain.Entities;
using AcademiaPro.Domain.Interfaces.Log;
using AcademiaPro.Domain.Interfaces.Repositories;
using AutoMapper;
using MediatR;

namespace AcademiaPro.Application.Features.Classes.Handlers.Queries
{
    public class GetClassesQueryHandler : IRequestHandler<GetClassesQuery, IEnumerable<LevelDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public GetClassesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, ILoggerManager logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IEnumerable<LevelDto>> Handle(GetClassesQuery request, CancellationToken cancellationToken)
        {
            //string connection = Environment.GetEnvironmentVariable("DefaultConnection");
            //_logger.LogInfo(connection);
            _logger.LogInfo("Fetching all Classes from database");
            var levels = await _unitOfWork.Levels.GetAllAsync(null, (IQueryable<Level> q) => q.OrderBy(l => l.SortOrder));
            _logger.LogInfo("Returning all the fetched classes");
            return _mapper.Map<IEnumerable<LevelDto>>(levels);
        }
    }
}