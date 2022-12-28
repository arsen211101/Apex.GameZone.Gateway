using Apex.GameZone.API.ViewModels.Section;
using Apex.GameZone.Core.Entities;
using AutoMapper;

namespace Apex.GameZone.API.MapperProfiles
{
    public class SectionProfile : Profile
    {
        public SectionProfile()
        {
            CreateMap<SectionViewModel, SectionModel>();
            CreateMap<SectionModel, SectionViewModel>();
        }
    }
}
