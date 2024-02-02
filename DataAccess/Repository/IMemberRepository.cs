using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> GetAllMembers();
        MemberObject GetMemberById(int memberId);

        void UpdateMember(MemberObject member);

        void DeleteMember(MemberObject member);

        void AddMember(MemberObject member);

        MemberObject CheckLogin(string mail, string pass);
    }
}
