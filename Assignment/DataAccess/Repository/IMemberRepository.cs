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
        public List<MemberObject> GetAll();
        public MemberObject? GetMemberById(string id);
        public void AddNewMember(MemberObject member);
        public void DeleteMember(MemberObject member);
        public void UpdateMember(MemberObject member);
        public List<string> GetAllCity();
        public List<string> GetAllCountry();
        public List<MemberObject> GetMemberByCity(string city);
        public List<MemberObject> GetMemberByCountry(string country);
        public List<MemberObject> GetMemberByIdAndName(string id, string name);
        public void SortMemberListByName();
        public MemberObject? MemberLogin(string email, string password);

    }
}
