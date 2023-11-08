using Microsoft.EntityFrameworkCore;
using DemoMvc.Models;

namespace DemoMvc.Data 
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {}
        public DbSet <Person> Person { get; set;} 
        public DbSet<Employee> Employee { get; set; } = default!;
        public DbSet<DemoMvc.Models.DaiLy> DaiLy { get; set; } = default!;
        public DbSet<DemoMvc.Models.HeThongPhanPhoi> HeThongPhanPhoi { get; set; } = default!;
    }
}