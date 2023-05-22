using Apex.GameZone.API.ViewModels.Checkout;
using Apex.GameZone.Core.Models;
using AutoMapper;

namespace Apex.GameZone.API.MapperProfiles
{
    public class ProductCheckoutProfile : Profile
    {
        public ProductCheckoutProfile()
        {
            CreateMap<ProductCheckoutViewModel, ProductCheckoutModel>();
            CreateMap<ProductCheckoutModel, ProductCheckoutViewModel>();
        }
    }
}