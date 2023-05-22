using Apex.GameZone.Core.Models;
using Apex.GameZone.Data.Entities;
using AutoMapper;

namespace Apex.GameZone.Core.MapperProfiles;

public class ProductCheckoutProfile : Profile
{
    public ProductCheckoutProfile()
    {
        CreateMap<ProductCheckoutModel, ProductCheckoutEntity>();
        CreateMap<ProductCheckoutEntity, ProductCheckoutModel>();
    }
}
