using DynamicPlugins.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DynamicPlugins.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        public DbSet<Plugin> Plugins { get; set; }
        public DbSet<PluginMigration> PluginMigrations { get; set; }
    }

    public class DataContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyContext>();
            builder.UseMySql("server=127.0.0.1;port=3306;database=pluging;uid=root;pwd=password;");
            return new MyContext(builder.Options);
        }
    }
}
