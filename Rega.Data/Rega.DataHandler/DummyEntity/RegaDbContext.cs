using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Rega.DataHandler.DummyEntity;

public partial class RegaDbContext : DbContext
{
    public RegaDbContext()
    {
    }

    public RegaDbContext(DbContextOptions<RegaDbContext> options)
        : base(options)
    {
    }


    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
