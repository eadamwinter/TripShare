using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripShare;

namespace WebTripShare.Models.AddingData
{
    public class DontUse
    {
        private readonly AppDbContext _appDbContext;

        public DontUse(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddTableData()
        {
            var tabela = new TableInfo()
            {
                TableInfoId = 1,
                TableName = "Górskie Małrze",
                Members = new List<MembersInfo>()
                {
                    new MembersInfo(){MembersInfoId=1, Name="Adam", TableNumber=1}, 
                    new MembersInfo() {MembersInfoId=2, Name="Igor", TableNumber=1}, 
                    new MembersInfo() {MembersInfoId=3, Name="Tomek", TableNumber=1}, 
                    new MembersInfo() {MembersInfoId=4, Name="Heniek", TableNumber=1}
                }
            };
            _appDbContext.Tables.Add(tabela);
            _appDbContext.SaveChanges();
        }



    }
}
