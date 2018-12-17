using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using QGEP.Authorization.Roles;
using QGEP.Authorization.Users;
using QGEP.Customers;
using QGEP.MultiTenancy;

namespace QGEP.EntityFramework
{
    public class QGEPDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public QGEPDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in QGEPDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of QGEPDbContext since ABP automatically handles it.
         */
        public QGEPDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public QGEPDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public QGEPDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        public virtual DbSet<Customer> Customer { get; set; }
    }
}
