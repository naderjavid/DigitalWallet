﻿using DigitalWallet.Features.MultiCurrency;
using DigitalWallet.Features.UserWallet.Domain;
using Microsoft.EntityFrameworkCore;

namespace DigitalWallet.Common.Persistence;

public class WalletDbContext : DbContext
{
    public WalletDbContext(DbContextOptions<WalletDbContext> dbContextOptions)
        : base(dbContextOptions)
    {

    }

    public DbSet<Currency> Currencies => Set<Currency>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var assembly = typeof(IAssemblyMarker).Assembly;
        modelBuilder.ApplyConfigurationsFromAssembly(assembly);
    }
}