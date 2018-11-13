using QGEP.EntityFramework;
using EntityFramework.DynamicFilters;

namespace QGEP.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly QGEPDbContext _context;

        public InitialHostDbBuilder(QGEPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
