using shopmvc.Models; 
using Microsoft.EntityFrameworkCore;

namespace shopmvc.Data; // part of Data namespace

public ProductDbContext : DbContext
{
    // list all of the sets 
    public DbSet<Models.Product> Products { get; set; } // DbSet - think of as list, part of Microsoft.EntityFrameworkCore

    // create construtor that will set default options
    public ProductDbContext(DbContextOptions<ProductDbContext> options)
    : base(options) {}
}