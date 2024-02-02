using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void AddMember(MemberObject member) => MemberDAO.Instance.AddNew(member);


        public IEnumerable<MemberObject> GetAllMembers() => MemberDAO.Instance.GetMemberList;

        public MemberObject GetMemberById(int memberId) => MemberDAO.Instance.getMemberById(memberId);

        public MemberObject CheckLogin(string mail, string pass) => MemberDAO.Instance.checkLogin(mail, pass);

        public void UpdateMember(MemberObject member) => MemberDAO.Instance.Update(member);

        public void DeleteMember(MemberObject member) => MemberDAO.Instance.Delete(member);
    
    }
}
