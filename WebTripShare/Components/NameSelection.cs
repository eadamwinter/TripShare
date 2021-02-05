using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripShare;

namespace WebTripShare.Components
{
    public class NameSelection:ViewComponent
    {
        private readonly IMembersRepository _membersrepository;

        public NameSelection(IMembersRepository membersRepository)
        {
            _membersrepository = membersRepository;
        }
        public IViewComponentResult Invoke(int id)
        {
            var data = _membersrepository.GetAllMembers(id);
            return View(data);
        }
    }
}
