using Apex.GameZone.Core.Entities;
using Apex.GameZone.Data.Entities;
using AutoMapper;

namespace Apex.GameZone.Core.MapperProfiles
{
    public class GameZoneProfile : Profile
    {
        public GameZoneProfile()
        {
            CreateMap<GameZoneEntity, GameZoneModel>();
            CreateMap<GameZoneModel, GameZoneEntity>();
        }
    }
}
