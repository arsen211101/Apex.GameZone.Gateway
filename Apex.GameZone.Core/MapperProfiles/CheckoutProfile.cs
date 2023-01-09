using Apex.GameZone.Core.Models;
using Apex.GameZone.Data.Entities;
using AutoMapper;

namespace Apex.GameZone.Core.MapperProfiles;

public class CheckoutProfile : Profile
{
    public CheckoutProfile()
    {
        CreateMap<CheckoutModel, CheckoutEntity>();
        CreateMap<CheckoutEntity, CheckoutModel>();
    }
}