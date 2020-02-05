using Microsoft.EntityFrameworkCore;
using SportsApp.API.Models;

namespace SportsApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        
        public DbSet<Value> Values { get; set; }

    
}
    }