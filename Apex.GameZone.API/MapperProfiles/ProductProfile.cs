using Apex.GameZone.API.ViewModels.Product;
using Apex.GameZone.Core.Entities;
using AutoMapper;

namespace Apex.GameZone.API.MapperProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductViewModel, ProductModel>();
            CreateMap<ProductModel, ProductViewModel>();
        }
    }
}
