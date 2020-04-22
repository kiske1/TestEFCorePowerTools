using Microsoft.EntityFrameworkCore;

namespace TestEFCorePowerTools.Data
{
    class TestDbContextFactory : DesignTimeDbContextFactoryBase<TestDbContext>
    {
        protected override TestDbContext CreateNewInstance(DbContextOptions<TestDbContext> options)
        {
            return new TestDbContext(options);
        }
    }
}
