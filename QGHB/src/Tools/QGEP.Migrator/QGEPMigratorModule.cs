using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using QGEP.EntityFramework;

namespace QGEP.Migrator
{
    [DependsOn(typeof(QGEPDataModule))]
    public class QGEPMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<QGEPDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}