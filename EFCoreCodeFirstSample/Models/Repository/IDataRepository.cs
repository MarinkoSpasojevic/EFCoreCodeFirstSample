using System.Collections.Generic;

namespace EFCoreCodeFirstSample.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
        int Add(TEntity entity);
        int Update(long id, TEntity entity);
        int Delete(long id);
    }
}
