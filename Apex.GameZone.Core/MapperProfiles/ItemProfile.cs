using Apex.GameZone.Core.Entities;
using Apex.GameZone.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apex.GameZone.Core.MapperProfiles
{
    public class ItemProfile
    {
        public ItemProfile()
        {
            CreateMap<GameZoneEntity, GameZoneModel>();
            CreateMap<GameZoneModel, GameZoneEntity>();
        }
       
    }
}
