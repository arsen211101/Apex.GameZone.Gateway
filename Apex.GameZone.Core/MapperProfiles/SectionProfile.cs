using Apex.GameZone.Core.Entities;
using Apex.GameZone.Data.Entities;
using AutoMapper;

namespace Apex.GameZone.Core.MapperProfiles
{
    public class SectionProfile : Profile
    {
        public SectionProfile()
        {
            CreateMap<SectionEntity, SectionModel>();
            CreateMap<SectionModel, SectionEntity>();

            CreateMap<SectionEntity, SectionEntity>();

        }
    }
}
