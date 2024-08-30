using AcademiaPro.Contracts.Classes;
using AcademiaPro.Contracts.Classrooms;
using AcademiaPro.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaPro.Application.Configurations
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Level, ListLevelDto>().ReverseMap();
            CreateMap<Classroom, ListClassroomDto>().ReverseMap();
        }

    }
}
