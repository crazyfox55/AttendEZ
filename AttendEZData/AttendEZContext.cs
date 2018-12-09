using AttendEZData.Models;
using Microsoft.EntityFrameworkCore;

namespace AttendEZData
{
    public class AttendEZContext : DbContext
    {
        public AttendEZContext(DbContextOptions options) :
            base(options)
        {

        }

        public DbSet<Organization> Users { get; set; }
    }
}
