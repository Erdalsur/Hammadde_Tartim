using Sanmark.Core.Entities;
using System;
using System.Linq;

namespace Sanmark.Core.DataAccess
{
    public interface IQueryableRepository<T> where T : class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}
