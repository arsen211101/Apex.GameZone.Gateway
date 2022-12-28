using Apex.GameZone.Data.Entities;
using Apex.GameZone.Data.Specifications.Common;
using Apex.GameZone.Shared.Enums;

namespace Apex.GameZone.Data.Repositories.Common
{
    public interface ICommonRepository<TEntity> where TEntity : BaseEntity
    {
        void Update(TEntity entity);
        Task<List<TEntity>> GetAll(bool includeDeleted = false);

        Task<TEntity> GetById(int id, bool includeDeleted = false);

        Task<List<TEntity>> GetAllBySpecification(ICommonSpecification<TEntity> commonSpecification, bool includeDeleted = false);

        Task<TEntity> GetSingleBySpecification(ICommonSpecification<TEntity> commonSpecification, bool includeDeleted = false);

        Task Add(TEntity entity);

        Task AddRange(List<TEntity> entities);

        void Delete(TEntity entity, DeleteOptions deleteOption = DeleteOptions.Soft);

        void DeleteRange(IEnumerable<TEntity> entities, DeleteOptions deleteOption = DeleteOptions.Soft);
    }
}
