using GestaoDeLaboratorios.Models;
using Microsoft.EntityFrameworkCore;

public class InfnetDbContext : DbContext
{
    public InfnetDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Computadores> Computadores { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }

}