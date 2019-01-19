using DatingApp.API.Model;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbContextOptionsBuilder):base(dbContextOptionsBuilder)
        {
            
        }
        public DbSet<Value> Values { get; set; }
    }
}