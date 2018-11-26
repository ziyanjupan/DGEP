using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using QGEP.EntityFramework;

namespace QGEP
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(QGEPCoreModule))]
    public class QGEPDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<QGEPDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
            Configuration.UnitOfWork.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
