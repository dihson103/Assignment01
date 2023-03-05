using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void AddNewMember(MemberObject member) => MemberDao.Instance.AddNewMember(member);

        public void DeleteMember(MemberObject member) => MemberDao.Instance.RemoveMember(member);

        public List<MemberObject> GetAll() => MemberDao.Instance.GetMemberList;

        public MemberObject? GetMemberById(string id) => MemberDao.Instance.GetMemberById(id);

        public void UpdateMember(MemberObject member) => MemberDao.Instance.UpdateMember(member);
        public List<string> GetAllCity() => MemberDao.Instance.GetCityList();
        public List<string> GetAllCountry() => MemberDao.Instance.GetCountryList();
        public List<MemberObject> GetMemberByCity(string city) => MemberDao.Instance.GetMemberByCity(city);
        public List<MemberObject> GetMemberByCountry(string country) => MemberDao.Instance.GetMemberByCountry(country);
        public List<MemberObject> GetMemberByIdAndName(string id, string name) => MemberDao.Instance.GetMemberByIdAndName(id, name);
        public void SortMemberListByName() => MemberDao.Instance.SortMemberListByName();
        public MemberObject? MemberLogin(string email, string password) => MemberDao.Instance.GetMemberByEmailAndPassword(email, password); 
    }
}
