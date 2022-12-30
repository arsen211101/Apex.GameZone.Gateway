using Apex.GameZone.Core.Entities;
using Apex.GameZone.Core.Services.Common;
using Apex.GameZone.Data.Entities;
using Apex.GameZone.Data.Repositories.UoW;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
