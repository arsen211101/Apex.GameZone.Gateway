using Apex.GameZone.API.ViewModels;
using Apex.GameZone.Core.Models;
using AutoMapper;

namespace Apex.GameZone.API.MapperProfiles;

public class GameZoneProfile : Profile
{
    public GameZoneProfile()
    {
        CreateMap<GameZoneViewModel, GameZoneModel>();
        CreateMap<GameZoneModel, GameZoneViewModel>();
    }
}