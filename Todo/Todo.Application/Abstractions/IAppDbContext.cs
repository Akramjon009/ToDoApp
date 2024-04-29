﻿using Microsoft.EntityFrameworkCore;
using Todo.Domain.Entities;

namespace Todo.Application.Abstractions
{
    public interface IAppDbContext
    {
        DbSet<Issue> Issues { get; set; }
        DbSet<Comment> Comments { get; set; }

        public ValueTask<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
