using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public List<MemberObject> GetListAllMember()
             => MemberDAO.Instance.GetListAllMember;

        public MemberObject GetMemberByID(int id)
            => MemberDAO.Instance.GetMemberByID(id);

        public MemberObject GetMemberByEmailAndPassword(string email, string password)
            => MemberDAO.Instance.GetMemberByEmailAndPassword(email, password);

        public void InsertMember(MemberObject member)
            => MemberDAO.Instance.InsertMember(member);

        public void UpdateMember(MemberObject updatedMember)
            => MemberDAO.Instance.UpdateMember(updatedMember);

        public void DeleteMember(int id)
            => MemberDAO.Instance.DeleteMember(id);

        public List<MemberObject> SearchMemberByID(int id)
            => MemberDAO.Instance.SearchMemberByID(id);

        public List<MemberObject> SearchMemberByName(string name)
            => MemberDAO.Instance.SearchMemberByName(name);
        public List<MemberObject> SearchMemberByCity(string city)
            => MemberDAO.Instance.SearchMemberByName(city);
        public List<MemberObject> SearchMemberByCountry(string country)
            => MemberDAO.Instance.SearchMemberByName(country);
        public List<MemberObject> SearchMemberByEmail(string email)
            => MemberDAO.Instance.SearchMemberByName(email);

        public List<MemberObject> FilterByCity(string city)
            => MemberDAO.Instance.FilterByCity(city);

        public List<MemberObject> FilterByCountry(string country)
            => MemberDAO.Instance.FilterByCountry(country);
        public List<string> GetCities()
            => MemberDAO.Instance.GetCities();

        public List<string> GetCountries()
            => MemberDAO.Instance.GetCountries();
        public List<string> GetCitiesByCountry(string country)
            => MemberDAO.Instance.GetCitiesByCountry(country);
        public void SortMembersAscendingID()
            => MemberDAO.Instance.SortMembersAscendingID();
        public void SortMembersDescendingID()
            => MemberDAO.Instance.SortMembersDescendingID();
        public void SortMembersAscendingName()
            => MemberDAO.Instance.SortMembersAscendingName();
        public void SortMembersDescendingName()
            => MemberDAO.Instance.SortMembersDescendingName();

    }
}
