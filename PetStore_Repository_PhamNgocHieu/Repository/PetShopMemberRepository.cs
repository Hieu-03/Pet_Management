using Microsoft.EntityFrameworkCore;
using PetStore_Repository_PhamNgocHieu.Models;
using PetStore_Repository_PhamNgocHieu.Dao;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore_Repository_PhamNgocHieu.Repository
{
    public class PetShopMemberRepository : IPetShopMemberRepository
    {
        public PetShopMember GetMember(string id) => MemberDbContext.Instance.GetMemberById(id);

        public IEnumerable<PetShopMember> GetMembers() => MemberDbContext.Instance.GetAllMembers();
    }
}
