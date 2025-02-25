﻿using GettingBetter.API.Shared.Domain.Repositories;
using GettingBetter.API.Shared.Persistence.Contexts;

namespace GettingBetter.API.Shared.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }
}