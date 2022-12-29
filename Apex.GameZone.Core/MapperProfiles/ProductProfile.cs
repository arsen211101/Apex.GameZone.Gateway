using Apex.GameZone.Core.Models;
using Apex.GameZone.Data.Entities;
using AutoMapper;

namespace Apex.GameZone.Core.MapperProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductEntity, ProductModel>();
            CreateMap<ProductModel, ProductEntity>();
            CreateMap<ProductEntity, ProductEntity>();

        }
    }
}
