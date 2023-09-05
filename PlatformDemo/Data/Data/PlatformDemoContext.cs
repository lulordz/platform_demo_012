using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Data.Data;

public partial class PlatformDemoContext : DbContext
{
    public PlatformDemoContext()
    {
    }

    public PlatformDemoContext(DbContextOptions<PlatformDemoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-D0F7ATP;Database=PlatformDemo;Trusted_Connection=True;TrustServerCertificate=True");

}
