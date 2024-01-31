using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public List<MemberObject> GetListAllMember();
        public MemberObject GetMemberByID(int id);
        public MemberObject GetMemberByEmailAndPassword(string email, string password);
        public void InsertMember(MemberObject member);
        public void UpdateMember(MemberObject updatedMember);
        public void DeleteMember(int id);
        public List<MemberObject> SearchMemberByID(int id);
        public List<MemberObject> SearchMemberByName(string name);
        public List<MemberObject> SearchMemberByCity(string city);
        public List<MemberObject> SearchMemberByCountry(string country);
        public List<MemberObject> SearchMemberByEmail(string email);
        public List<MemberObject> FilterByCity(string city);
        public List<MemberObject> FilterByCountry(string country);
        public List<string> GetCities();
        public List<string> GetCountries();
        public List<string> GetCitiesByCountry(string country);
        public void SortMembersAscendingID();
        public void SortMembersDescendingID();
        public void SortMembersAscendingName();
        public void SortMembersDescendingName();
    }
}
