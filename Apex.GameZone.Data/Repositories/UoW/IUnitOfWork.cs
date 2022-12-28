using Apex.GameZone.Data.Entities;
using Apex.GameZone.Data.Repositories.Common;

namespace Apex.GameZone.Data.Repositories.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        ICommonRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;

        Task SaveChangesAsync();
    }
}
