using GaziU.HukukBuroOtomasyonu.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaziU.HukukBuroOtomasyonu.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Avukat> Avukatlar { get; set; }
        public DbSet<DavaDosyasi> DavaDosyalar { get; set; }
        public DbSet<Durusma> Durusmalar { get; set; }
        public DbSet<YargiTuru> YargiTurler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HukukDb;Integrated Security=True;");
        }
    }
}
