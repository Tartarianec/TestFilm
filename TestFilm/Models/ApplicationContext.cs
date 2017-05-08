using Microsoft.EntityFrameworkCore;
using TestFilm.Models;

namespace TestFilm.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Film> Films { get; set; }

        public DbSet<FileModel> Files { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        { }
    }
}
