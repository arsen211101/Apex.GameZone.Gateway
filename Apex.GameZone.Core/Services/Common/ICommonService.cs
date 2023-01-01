using Apex.GameZone.Core.Models;
using Apex.GameZone.Data.Entities;
using Apex.GameZone.Data.Specifications.Common;

namespace Apex.GameZone.Core.Services.Common;

public interface ICommonService<TModel, TEntity>
    where TEntity : BaseEntity
    where TModel : BaseModel
{
    Task<TModel> GetById(int id, bool includeDeleted = false);
    Task<List<TModel>> GetAll(bool includeDeleted = false);
    Task<List<TModel>> GetAll(ICommonSpecification<TEntity> specification, bool includeDeleted = false);
    Task<TModel> GetSingleBySpecification(ICommonSpecification<TEntity> specification, bool includeDeleted = false);
    Task<int> Add(TModel model);
    Task Update(TModel model);
    Task Delete(TModel model);
    Task Delete(int id);
}