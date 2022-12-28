using Apex.GameZone.Data.DAO;
using Apex.GameZone.Data.Entities;
using Apex.GameZone.Data.Repositories.Common;
using Apex.GameZone.Shared.CustomExceptions;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Apex.GameZone.Data.Repositories.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MainDbContext _context;
        private Hashtable _repositories;

        public UnitOfWork(MainDbContext context)
        {
            _context = context;
        }

        public ICommonRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var type = typeof(TEntity).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(CommonRepository<>);

                var repositoryInstance =
                    Activator.CreateInstance(repositoryType
                        .MakeGenericType(typeof(TEntity)), _context);

                _repositories.Add(type, repositoryInstance);
            }

            return (ICommonRepository<TEntity>)_repositories[type];
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task SaveChangesAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            //catch (DbUpdateConcurrencyException ex)
            //{
            //    throw new EntityUpdateConcurrencyException(ex.Entries);
            //}
            //catch (DbUpdateException ex) when (ex.ForeignKeyConstraintConflictOnInsert())
            //{
            //    throw new BadDataException("Related entity not found.");
            //}
            catch (Exception ex) 
            { 
                ex.ToString();
            }
          
        }
    }
}
