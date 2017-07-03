using System;
using System.Data.Entity;
using System.Threading.Tasks;
using MyChild.Data;

namespace MyChild.Data
{
    public class MyChildDbContext : DbContext
    {
        public MyChildDbContext(string connectionString)
        {
            this.Database.Connection.ConnectionString = connectionString;
        }

        public DbSet<Models.Author> Author { get; set; }
        public DbSet<Models.Blog> Blog { get; set; }


        public MyChildDbContext() : base("name=MyChildDataContext")
        {

        }

        internal Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
