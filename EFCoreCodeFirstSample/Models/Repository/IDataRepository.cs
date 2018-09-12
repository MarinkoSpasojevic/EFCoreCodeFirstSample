<<<<<<< HEAD
﻿using System.Collections.Generic;

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
=======
﻿using System.Collections.Generic;

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
>>>>>>> 8b36d19da2d59dd15ecf1226aa84353045f4e141
