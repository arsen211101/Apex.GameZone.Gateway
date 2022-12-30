using Apex.GameZone.Core.Entities;
using Apex.GameZone.Core.Services.Common;
using Apex.GameZone.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apex.GameZone.Core.Services.Item
{
    public interface IItemService : ICommonService<ItemModel, ItemEntity>
    {
    }
}
