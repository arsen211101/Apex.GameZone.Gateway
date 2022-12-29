using Apex.GameZone.Core.Models;
using Apex.GameZone.Core.Services.Common;
using Apex.GameZone.Data.Entities;

namespace Apex.GameZone.Core.Services.GameZone
{
    public interface IGameZoneService : ICommonService<GameZoneModel, GameZoneEntity>
    {
    }
}