using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripShare;

namespace WebTripShare.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Expense> ExpenseRepository { get; set; }
        public DbSet<TableInfo> TableRepository { get; set; }
        public DbSet<MembersInfo> MembersRepository { get; set; }

    }
}
