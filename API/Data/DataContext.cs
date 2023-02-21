using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    // going to be used as service
    public class DataContext : DbContext //inherits from DbContext for database query and tracking,
    {
        //pass the connection string using constructor
        //we are going to inject this into the program
        public DataContext(DbContextOptions options) : base(options) // to pass the connection string as an options
        {
        }

        public DbSet<AppUser> Users { get; set; } //table name is going to be called users and columns will be from AppUser controller
    }
}