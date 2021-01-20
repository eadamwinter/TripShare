using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripShare;

namespace WebTripShare.Models
{
    public class TableRepository : ITableRepository
    {
        private readonly AppDbContext appDbContext;
        public TableRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public TableInfo GetInformationAboutTable()
        {
            return appDbContext.Tables.First(t => t.TableInfoId == 1);
        }
    }
}
