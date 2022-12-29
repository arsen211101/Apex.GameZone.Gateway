using Apex.GameZone.Core.Models;
using Apex.GameZone.Core.Services.Common;
using Apex.GameZone.Data.Entities;
using Apex.GameZone.Data.Repositories.UoW;
using AutoMapper;

namespace Apex.GameZone.Core.Services.Item
{
    internal class ItemService : CommonService<ItemModel, ItemEntity>, IItemService
    {
        public ItemService(IUnitOfWork uow,
                            IMapper mapper) : base(uow, mapper)
        {

        }
    }
}
