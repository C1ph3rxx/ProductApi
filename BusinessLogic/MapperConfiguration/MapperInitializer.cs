using AutoMapper;
using Domain.DTO;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.MapperConfiguration
{
    public class MapperInitializer : Profile
    {

        public MapperInitializer()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CreateRequestCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryDto>().ReverseMap();
        }
    }
}
