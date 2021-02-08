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

        public void AddNewTable(NewTableViewModel model)
        {
            var id = appDbContext.Tables.Max(x => x.TableInfoId);
            id++;

            var memberId = appDbContext.Members.Max(x => x.MembersInfoId);

            List<MembersInfo> ListOfMembers = new List<MembersInfo>();

            foreach(var name in model.Names) 
            {
                memberId++;
                ListOfMembers.Add(new MembersInfo() { MembersInfoId = memberId, Name = name, TableNumber = id });
            }

            var tabela = new TableInfo()
            {
                TableInfoId = id,
                TableName = model.TableName,
                Members = ListOfMembers
            };

            appDbContext.Tables.Add(tabela);
            appDbContext.SaveChanges();
        }
    }
}
