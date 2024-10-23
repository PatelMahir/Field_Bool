using Microsoft.EntityFrameworkCore;
namespace Field_Bool.DB_Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Models.Abc_Any> ABCs { get; set; }
    }
}