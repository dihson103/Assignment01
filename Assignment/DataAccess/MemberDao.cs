using BusinessObject;

namespace DataAccess
{
    public class MemberDao
    {
         private static List<MemberObject> MemberList = new List<MemberObject>() {
            new MemberObject{ Id ="He160021",Name = "Dinh Son2", City = "Ha Noi", Country = "Viet Nam",
                Email = "dinhson2@gmail.com", Password = "12345"},
            new MemberObject{ Id ="He160031",Name = "Dinh Son3", City = "Ha Nam", Country = "Viet Nam",
                Email = "dinhson3@gmail.com", Password = "12345"},
            new MemberObject{ Id ="He160041",Name = "Dinh Son1", City = "Hai Phong", Country = "Viet Nam",
                Email = "dinhson1@gmail.com", Password = "12345"},
            new MemberObject{ Id ="He160051",Name = "Dinh Thang", City = "HCM", Country = "Viet Nam",
                Email = "dinhson123@gmail.com", Password = "12345"}
        };

        private static MemberDao instance = null;
        private MemberDao() { }
        public static MemberDao Instance
        {
            get 
            {
                if(instance == null)
                {
                    instance = new MemberDao();
                }
                return instance; 
            }
        }

        public List<MemberObject> GetMemberList => MemberList;

        public MemberObject? GetMemberById(string id)
        {
            MemberObject? member = MemberList.SingleOrDefault(x => x.Id == id);
            return member;
        }

        private MemberObject? GetMemberByEmail(string email)
        {
            return MemberList.SingleOrDefault(x => x.Email == email);
        }

        public MemberObject? GetMemberByEmailAndPassword(string email, string password)
        {
            return MemberList.SingleOrDefault(x => x.Email == email && x.Password == password);
        }

        private bool IsMemberIdExist(string id)
        {
            return GetMemberById(id) != null;
        }

        private bool IsMemberEmailExist(MemberObject m)
        {
            if (m.Email == "admin@fstore.com")
            {
                return true;
            }
            MemberObject? member = GetMemberByEmail(m.Email);
            if(member != null)
            {
                if(m.Id != member.Id)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddNewMember(MemberObject member)
        {
            if(IsMemberEmailExist(member))
            {
                throw new Exception("Email is already exist!!!");
            }
            if(IsMemberIdExist(member.Id))
            {
                throw new Exception("Member is already exist!!!");
            }
            MemberList.Add(member);
        }

        public void RemoveMember(MemberObject member)
        {
            MemberObject? m = GetMemberById(member.Id);
            if (m != null)
            {
                MemberList.Remove(m);
            }
            else
            {
                throw new Exception("Member does not already exist!!!");
            }
        }

        public void UpdateMember(MemberObject member)
        {
            MemberObject? m = GetMemberById(member.Id);
            if (m != null)
            {
                if(IsMemberEmailExist(member))
                {
                    throw new Exception("Email is already exist!!!");
                }
                var index = MemberList.IndexOf(m);
                MemberList[index] = member;
            }
            else
            {
                throw new Exception("Member does not already exist!!!");
            }
        }

        public List<string> GetCityList()
        {
            var cityList = MemberList.Select(x => x.City).Distinct().ToList();
            cityList.Insert(0, "All");
            return cityList;
        }

        public List<string> GetCountryList()
        {
            var countryList = MemberList.Select(x => x.Country).Distinct().ToList();
            countryList.Insert(0, "All");
            return countryList;
        }

        public List<MemberObject> GetMemberByCity(string city)
        {
            var member = MemberList.Where(x => x.City == city).ToList();
            return member;
        }

        public List<MemberObject> GetMemberByCountry(string country)
        {
            var member = MemberList.Where(x => x.Country== country).ToList();
            return member;
        }

        public List<MemberObject> GetMemberByIdAndName(string id, string name)
        {
            return MemberList.Where(x =>x.Id.Contains(id) && x.Name.Contains(name)).ToList();
        }

        public void SortMemberListByName()
        {
            MemberList.Sort();
        }
    }
}