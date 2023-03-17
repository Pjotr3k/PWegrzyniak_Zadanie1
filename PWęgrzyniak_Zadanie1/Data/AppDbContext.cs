using Microsoft.EntityFrameworkCore;
using PWęgrzyniak_Zadanie1.Models;

namespace PWęgrzyniak_Zadanie1.Data
{
    internal class AppDbContext : DbContext
    {
        private const string CONNECTION_STRING = @"Data Source=WYMIATACZ\SQLEXPRESS;Initial Catalog=Zadanie1DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }

        public DbSet<Produkt> Produkts { get; set; }
        public DbSet<ProduktZmiana> ProduktZmianas { get; set; }
        public DbSet<Narzedzie> Narzedzias { get; set; }
        public DbSet<NarzedzieUzycie> NarzedzieUzycies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=WYMIATACZ\SQLEXPRESS;Initial Catalog=Zadanie1DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            optionsBuilder.UseSqlServer(CONNECTION_STRING);

        }
    }
}
