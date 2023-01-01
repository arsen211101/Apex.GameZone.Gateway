using Apex.GameZone.Core.Models;
using Apex.GameZone.Data.Entities;
using AutoMapper;

namespace Apex.GameZone.Core.MapperProfiles;

public class GameZoneProfile : Profile
{
    public GameZoneProfile()
    {
        CreateMap<GameZoneEntity, GameZoneModel>();
        CreateMap<GameZoneModel, GameZoneEntity>();
        CreateMap<GameZoneEntity, GameZoneEntity>();
    }
}