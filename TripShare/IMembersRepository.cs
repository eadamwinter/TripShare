using System;
using System.Collections.Generic;
using System.Text;

namespace TripShare
{
    public interface IMembersRepository
    {
        IEnumerable<MembersInfo> GetAllMembers(int id);
    }
}
