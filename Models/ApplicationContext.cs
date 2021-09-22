using Microsoft.EntityFrameworkCore;
namespace dotnet_bakery.Models
{
    // This is link between
    // our app (controllers, etc)
    // and the database
    //
    // This is `_context`
    public class ApplicationContext : DbContext
    {
        // constructor
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {}

        // _context.Bakers
        public DbSet<Baker> Bakers {get; set;}

        // _context.Bread
        public DbSet<Bread> Breads {get; set;}
    }
}