using Apex.GameZone.API.ViewModels.Item;
using Apex.GameZone.Core.Models;
using AutoMapper;

namespace Apex.GameZone.API.MapperProfiles
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<ItemViewModel, ItemModel>();
            CreateMap<ItemModel, ItemViewModel>();
        }
    }
}
