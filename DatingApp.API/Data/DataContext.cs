using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base (options)
        {
            
        }

        // the type of property is from the model
        public DbSet<Value> Values { get; set;}
    }
}