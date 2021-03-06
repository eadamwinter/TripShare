﻿using Microsoft.EntityFrameworkCore;
using TripShare;

namespace WebTripShare.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Expense> Expenses { get; set; }
        public DbSet<TableInfo> Tables { get; set; }
        public DbSet<MembersInfo> Members { get; set; }

    }
}
