using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Data
{
    public class DesignTimeDbContextFactory
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // Use your MySQL connection string here
            var connectionString = "server=localhost;port=3306;database=LibraryDb;user=root;password=yourpassword";

            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
