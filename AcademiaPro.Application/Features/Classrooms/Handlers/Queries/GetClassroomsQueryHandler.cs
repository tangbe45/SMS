using AcademiaPro.Application.Features.Classrooms.Requests.Queries;
using AcademiaPro.Contracts.Classrooms;
using AcademiaPro.Domain.Entities;
using AcademiaPro.Domain.Interfaces.Log;
using AcademiaPro.Domain.Interfaces.Repositories;
using AutoMapper;
using MediatR;

namespace AcademiaPro.Application.Features.Classrooms.Handlers.Queries
{
    public class GetClassroomsQueryHandler : IRequestHandler<GetClassroomsQuery, IEnumerable<ListClassroomDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public GetClassroomsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, ILoggerManager logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IEnumerable<ListClassroomDto>> Handle(GetClassroomsQuery request, CancellationToken cancellationToken)
        {
            //string connection = Environment.GetEnvironmentVariable("DefaultConnection");
            //_logger.LogInfo(connection);
            _logger.LogInfo("Fetching all Classrooms from database");
            var classrooms = await _unitOfWork.Classrooms.GetAllAsync(null, (IQueryable<Classroom> q) => q.OrderBy(l => l.SortOrder));
            _logger.LogInfo("Returning all the fetched classes");
            return _mapper.Map<IEnumerable<ListClassroomDto>>(classrooms);
        }
    }
}