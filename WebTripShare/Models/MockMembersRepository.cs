using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripShare;

namespace WebTripShare.Models
{
    public class MockMembersRepository : IMembersRepository
    {
        public IEnumerable<MembersInfo> GetAllMembers(int id)
        {
            MemberMaker memberMaker = new MemberMaker();

            List<MembersInfo> memberslist = new List<MembersInfo>();
            memberslist.Add(memberMaker.CreateMember(1, "Igor"));
            memberslist.Add(memberMaker.CreateMember(1, "Adam"));
            memberslist.Add(memberMaker.CreateMember(1, "Tomek"));
            memberslist.Add(memberMaker.CreateMember(1, "Heniek"));

            return memberslist;
        }
    }
}
