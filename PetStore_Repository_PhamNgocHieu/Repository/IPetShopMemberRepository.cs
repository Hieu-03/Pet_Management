using Microsoft.EntityFrameworkCore;
using PetStore_Repository_PhamNgocHieu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore_Repository_PhamNgocHieu.Repository
{
    public interface IPetShopMemberRepository
    {
        IEnumerable<PetShopMember> GetMembers();
        PetShopMember GetMember(string id);
    }
}
