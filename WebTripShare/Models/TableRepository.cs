using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripShare;
using Microsoft.EntityFrameworkCore;

namespace WebTripShare.Models
{
    public class TableRepository : ITableRepository
    {
        private readonly AppDbContext appDbContext;
        public TableRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public TableInfo GetTableById(byte id)
        {
            return appDbContext.Tables.Include(a=>a.Members).FirstOrDefault(f=>f.TableInfoId==id);
        }

        public List<TableInfo> GetTables()
        {
            return appDbContext.Tables.ToList();
        }
    }
}
