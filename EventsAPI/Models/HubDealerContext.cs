using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsAPI.Repository;
using Microsoft.EntityFrameworkCore;
using EventsAPI.Models;

namespace EventsAPI.Models
{
    public class HubDealerContext : DbContext
{
    public HubDealerContext(DbContextOptions<HubDealerContext> dbContextOptions) : base(dbContextOptions)
    {
    
    }

    public DbSet<Evento> Eventos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Evento>().ToTable("Eventos", "dbo");
    }
}
}