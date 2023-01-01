using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Apex.GameZone.Data.Extensions;

public static class FilterExtensions
{
    public static void ApplyGlobalFilter<TEntity>(this ModelBuilder modelBuilder, string propertyName, TEntity value)
    {
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            var foundProperty = entityType.FindProperty(propertyName);

            if (foundProperty != null && foundProperty.ClrType == typeof(TEntity))
            {
                var newParameter = Expression.Parameter(entityType.ClrType);
                var filter =
                    Expression.Lambda(
                        Expression.Equal(Expression.Property(newParameter, propertyName), Expression.Constant(value)),
                        newParameter);

                modelBuilder.Entity(entityType.ClrType).HasQueryFilter(filter);
            }
        }
    }
}