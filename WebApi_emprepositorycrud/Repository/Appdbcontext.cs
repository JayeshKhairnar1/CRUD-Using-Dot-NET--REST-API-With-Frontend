using Microsoft.EntityFrameworkCore;
using WebApi_emprepositorycrud.Models;

namespace WebApi_emprepositorycrud.Repository
{
    public class Appdbcontext:DbContext
    {

        public Appdbcontext(DbContextOptions<Appdbcontext> options)
                 : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels\REST;Initial Catalog=DemoData;Integrated Security=True");
            }
        }
        //Data Source=(localdb)\ProjectModels;Initial Catalog=DemoData;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
        public DbSet<Employee> Employees { get; set; }
    }

    
}
