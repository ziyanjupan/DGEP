using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace QGEP.EntityFramework.Repositories
{
    public abstract class QGEPRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<QGEPDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected QGEPRepositoryBase(IDbContextProvider<QGEPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class QGEPRepositoryBase<TEntity> : QGEPRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected QGEPRepositoryBase(IDbContextProvider<QGEPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
