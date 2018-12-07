using System.Linq;
using QGEP.EntityFramework;
using QGEP.MultiTenancy;

namespace QGEP.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly QGEPDbContext _context;

        public DefaultTenantCreator(QGEPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
