using BusinessObject;
using System.Diagnostics;

namespace DataAccess
{
    public class MemberDAO
    {
        private static List<MemberObject> list = new List<MemberObject>()
        {
            new MemberObject(){MemberID = 1, MemberName = "Nguyen Van A", Email = "a@gmail.com", Password = "123", City = "Ha Noi", Country = "Viet Nam" },
            new MemberObject(){MemberID = 2, MemberName = "Nguyen Van B", Email = "b@gmail.com", Password = "1234", City = "Ho Chi Minh", Country = "Viet Nam" },
            new MemberObject(){MemberID = 3, MemberName = "John Wick", Email = "john@gmail.com", Password = "12345", City = "London", Country = "UK" },
            new MemberObject(){MemberID = 4, MemberName = "Satoh Takeru", Email = "satoh@gmail.com", Password = "123456", City = "Tokyo", Country = "Japan" },
            new MemberObject(){MemberID = 5, MemberName = "Tom Hank", Email = "tom@gmail.com", Password = "1234567", City = "New York", Country = "USA" }
        };

        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public List<MemberObject> GetMemberList => list;
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                }
                return instance;
            }
        }
        public MemberObject getMemberById(int id)
        {
            MemberObject member = list.SingleOrDefault(pro => pro.MemberID == id);
            return member;
        }
        public void Update(MemberObject member)
        {
            MemberObject obj = getMemberById(member.MemberID);
            if (obj != null)
            {
                var index = list.IndexOf(obj);
                list[index] = member;
            }
            else
            {
                throw new Exception("Member is not exists.");
            }
        }

        public void Delete(MemberObject member)
        {
            MemberObject obj = getMemberById(member.MemberID);
            if (obj != null)
            {
                list.Remove(obj);
            }
            else
            {
                throw new Exception("Member do not exists.");
            }
        }

        public void AddNew(MemberObject member)
        {
            MemberObject obj = getMemberById(member.MemberID);
            if (obj == null)
            {
                list.Add(member);
            }
            else
            {
                throw new Exception("Car is already exists.");
            }
        }

        public MemberObject checkLogin(string mail, string pass)
        {
            MemberObject obj = list.SingleOrDefault(pro => pro.Email.Equals(mail));
            if (obj != null)
            {
                return obj;
            }
            return null;
        }
    }
}