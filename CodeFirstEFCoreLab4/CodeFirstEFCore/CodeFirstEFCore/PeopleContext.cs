using Microsoft.EntityFrameworkCore;

namespace CodeFirstEFCore
{
    public class PeopleContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public PeopleContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectsV13;Database=CodeFirstEFCore;Trusted_Connection=True");
            //ChangeTracker.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasKey(P => P.PersonId);
        }
    }
}
