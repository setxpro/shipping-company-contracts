using Microsoft.EntityFrameworkCore;
using ShippingCompanyContracts.Contracts.Camilo;

namespace ShippingCompanyContracts.Data;

public class AppDbContext : DbContext
{
    public DbSet<Camilo> Camilos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Banco.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}