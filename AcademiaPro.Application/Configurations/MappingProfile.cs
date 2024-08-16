﻿using AcademiaPro.Contracts.Classes;
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
            CreateMap<Level, LevelDto>().ReverseMap();
            CreateMap<Level, CreateLevelDto>().ReverseMap();
        }
    }
}
