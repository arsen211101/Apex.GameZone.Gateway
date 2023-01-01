using Apex.GameZone.Core.Models;
using Apex.GameZone.Data.Entities;
using AutoMapper;

namespace Apex.GameZone.Core.MapperProfiles;

public class ItemProfile : Profile
{
    public ItemProfile()
    {
        CreateMap<ItemEntity, ItemModel>();
        CreateMap<ItemModel, ItemEntity>();
        CreateMap<ItemEntity, ItemEntity>();
    }
}