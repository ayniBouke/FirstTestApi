using ApiTest.EntityLayer;
using System.Data.Entity; 

namespace ApiTest.DataLayer
{
    public class ApiTestContext : DbContext
    {

        public ApiTestContext() : base(DatabaseConnection.ConnectionString) { }

        public ApiTestContext(string connectionstring) : base(connectionstring) { }
        public ApiTestContext(string connectionstring, bool lazyLoading, bool creationProxy) : base(connectionstring)
        {
            this.Configuration.LazyLoadingEnabled = lazyLoading;
            this.Configuration.ProxyCreationEnabled = creationProxy;
        }
        public ApiTestContext(bool lazyLoading) : base()
        {
            this.Configuration.LazyLoadingEnabled = lazyLoading;
        }
        public ApiTestContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 

        }
        public DbSet<PersonneEntity> PersonneEntities { get; set; }
        public DbSet<PersonneTestEntity> PersonneTestEntities { get; set; }
        public DbSet<EmployeeEntity> EmployeeEntities { get; set; }
        public DbSet<TodoItemEntity> Items { get; set; }
    }
}
