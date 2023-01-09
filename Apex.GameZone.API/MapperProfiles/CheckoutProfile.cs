using Apex.GameZone.API.ViewModels;
using Apex.GameZone.API.ViewModels.Checkout;
using Apex.GameZone.Core.Models;
using AutoMapper;

namespace Apex.GameZone.API.MapperProfiles;

public class CheckoutProfile : Profile
{
    public CheckoutProfile()
    {
        CreateMap<CheckoutViewModel, CheckoutModel>();
        CreateMap<CheckoutModel, CheckoutViewModel>();
    }
}