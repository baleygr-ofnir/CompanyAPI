using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CompanyAPI.Models;

public partial class CompaniesContext : DbContext
{
    public CompaniesContext()
    {
    }

    public CompaniesContext(DbContextOptions<CompaniesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Company> Companies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
