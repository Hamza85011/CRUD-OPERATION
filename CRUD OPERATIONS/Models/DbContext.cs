namespace CRUD_OPERATIONS.Models
{
    public class DbContext: DbContext
    {

        // DbSet properties for database tables
        public DbSet<Employee> Employees { get; set; }
       

        // Constructor to configure the context options
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // Optional: Additional configuration can be done in the OnModelCreating method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Custom entity configurations or relationships can be defined here
            // Example: modelBuilder.Entity<Employee>().Property(e => e.Name).IsRequired();
        }
    }
}
