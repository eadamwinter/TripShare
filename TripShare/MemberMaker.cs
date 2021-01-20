using System;
using System.Collections.Generic;
using System.Text;

namespace TripShare
{
    public class MemberMaker
    {
        public MembersInfo CreateMember(byte tableNumber, string name)
        {
            MembersInfo member = new MembersInfo();
            member.TableNumber = tableNumber;
            member.Name = name;
            return member;
        }
    }
}
