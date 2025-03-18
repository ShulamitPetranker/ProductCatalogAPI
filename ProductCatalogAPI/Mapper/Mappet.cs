using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProductCatalogAPI.Dtos;

namespace ProductCatalogAPI.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Entities.Category, CategoryDto>()
                .ConstructUsing(src => new CategoryDto(
                    src.CategoryId,
                    src.CategoryName,
                    src.CategoryDescription));

            CreateMap<CategoryDto, Entities.Category>();
        }
    }
}
