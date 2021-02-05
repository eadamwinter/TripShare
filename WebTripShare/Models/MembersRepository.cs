using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripShare;

namespace WebTripShare.Models
{
    public class MembersRepository : IMembersRepository
    {
        private readonly AppDbContext appDbContext;
        public MembersRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<MembersInfo> GetAllMembers(int id)
        {
            return appDbContext.Members.Where(m => m.TableNumber == (byte)id);
        }
    }
}
