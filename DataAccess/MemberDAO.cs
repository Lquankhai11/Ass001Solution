using BusinessObject;


namespace DataAccess
{
    public class MemberDAO
    {
        //Initialize member list
        private static List<MemberObject> memberList = new List<MemberObject>() {
            new MemberObject(1, "Le Van A", "vana@fpt.edu.vn", "123456789", "Hanoi", "Vietnam"),
            new MemberObject(2, "Nguyen Thi B", "bnguyen@gmail.com", "987654321", "Ho Chi Minh City", "Vietnam"),
            new MemberObject(3, "Tran Van C", "ctran@yahoo.com", "qwerty123", "Da Nang", "Vietnam"),
            new MemberObject(4, "John Smith", "john.smith@example.com", "password123", "New York", "United States"),
            new MemberObject(5, "Maria Rodriguez", "maria.rodriguez@example.com", "secure456", "Barcelona", "Spain"),
            new MemberObject(6, "Yuki Tanaka", "yuki.tanaka@example.com", "japan123", "Tokyo", "Japan"),
            new MemberObject(7, "Mikhail Ivanov", "mikhail.ivanov@example.com", "russia789", "Moscow", "Russia"),
            new MemberObject(8, "Luisa Costa", "luisa.costa@example.com", "portugal456", "Lisbon", "Portugal"),
            new MemberObject(9, "Sven Schmidt", "sven.schmidt@example.com", "germany789", "Berlin", "Germany"),
            new MemberObject(10, "Elena Petrova", "elena.petrova@example.com", "russia123", "Saint Petersburg", "Russia"),
            new MemberObject(11, "Alessia Rossi", "alessia.rossi@example.com", "italy456", "Rome", "Italy"),
            new MemberObject(12, "Hiroshi Nakamura", "hiroshi.nakamura@example.com", "japan789", "Osaka", "Japan"),
            new MemberObject(13, "Sophie Martin", "sophie.martin@example.com", "france123", "Paris", "France"),
            new MemberObject(14, "Carlos Hernandez", "carlos.hernandez@example.com", "mexico456", "Mexico City", "Mexico"),
            new MemberObject(15, "Anna Kowalski", "anna.kowalski@example.com", "poland123", "Warsaw", "Poland"),
            new MemberObject(16, "Mohammed Ali", "mohammed.ali@example.com", "egypt456", "Cairo", "Egypt"),
            new MemberObject(17, "Isabella Silva", "isabella.silva@example.com", "brazil123", "Sao Paulo", "Brazil"),
            new MemberObject(18, "Cheng Wei", "cheng.wei@example.com", "china456", "Beijing", "China"),
            new MemberObject(19, "Anita Kumar", "anita.kumar@example.com", "india123", "New Delhi", "India"),
            new MemberObject(20, "Yuki Kim", "yuki.kim@example.com", "korea456", "Seoul", "South Korea")
        };

        //using Singleton Pattern
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO(){ }
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
                    return instance;
                }
            }
        }

        //Read - List all member 
        public List<MemberObject> GetListAllMember => memberList;


        //Read - List all member by email & password
        public MemberObject GetMemberByEmailAndPassword(string email, string password)
        {
            return memberList.SingleOrDefault(member => member.Email.Equals(email)
                && member.Password.Equals(password));
        }

        //Read - List member by id
        public MemberObject GetMemberByID(int memId)
        {
            return memberList.SingleOrDefault(member => member.MemberID == memId);
        }

        //Create - create member
        public void InsertMember(MemberObject member)
        {
            if (GetMemberByID(member.MemberID) != null)
            {
                throw new Exception("Member already exists!");
            }
            memberList.Add(member);
        }

        //Update - update member
        public void UpdateMember(MemberObject memberUpdate)
        {
            MemberObject member = GetMemberByID(memberUpdate.MemberID);
            if (member == null)
            {
                throw new Exception("Member does not exist!");
            }
            member.MemberName = memberUpdate.MemberName;
            member.Email = memberUpdate.Email;
            member.Password = memberUpdate.Password;
            member.City = memberUpdate.City;
            member.Country = memberUpdate.Country;
        }

        //Delete - delete member
        public void DeleteMember(int memId)
        {
            MemberObject member = GetMemberByID(memId);
            if (member == null)
            {
                throw new Exception("Member does not exist!");
            }
            memberList.Remove(member);
        }

        //Search - search by name
        public List<MemberObject> SearchMemberByName(string name)
        {
            return memberList.Where(member => member.MemberName.ToLower().Contains(name.ToLower())).ToList();
        }

        //Search - search by city
        public List<MemberObject> SearchMemberByCity(string city)
        {
            return memberList.Where(member => member.City.ToLower().Contains(city.ToLower())).ToList();
        }

        //Search - search by country
        public List<MemberObject> SearchMemberByCountry(string country)
        {
            return memberList.Where(member => member.Country.ToLower().Contains(country.ToLower())).ToList();
        }

        //Search - search by email
        public List<MemberObject> SearchMemberByEmail(string email)
        {
            return memberList.Where(member => member.Email.ToLower().Contains(email.ToLower())).ToList();
        }

        //Search - search by id
        public List<MemberObject> SearchMemberByID(int id)
        {
            return memberList.Where(member => member.MemberID.ToString().Contains(id.ToString())).ToList();
        }

        //Filter - filter by country
        public List<MemberObject> FilterByCountry(string country)
        {
            return memberList.Where(member => member.Country.ToLower().Contains(country.ToLower())).ToList();
        }

        //Filter - filter by city
        public List<MemberObject> FilterByCity(string city)
        {
            return memberList.Where(member => member.City.ToLower().Contains(city.ToLower())).ToList();
        }


        //Read - get all city
        public List<string> GetCities()
        {
            return memberList.Select(member => member.City).Distinct().ToList();
        }

        //Read - get all country
        public List<string> GetCountries()
        {
            return memberList.Select(member => member.Country).Distinct().ToList();
        }

        //Read - get city by country
        public List<string> GetCitiesByCountry(string country)
        {
            return memberList.Where(member => member.Country.Equals(country)).Select(member => member.City).Distinct().ToList();
        }

        //Sort - sort member ascending by id
        public void SortMembersAscendingID()
        {
            memberList = memberList.OrderBy(member => member.MemberID).ToList();
        }

        //Sort - sort member descending by id
        public void SortMembersDescendingID()
        {
            memberList = memberList.OrderByDescending(member => member.MemberID).ToList();
        }

        //Sort - sort member ascending by name
        public void SortMembersAscendingName()
        {
            memberList = memberList.OrderBy(member => member.MemberName).ToList();
        }

        //Sort - sort member descending by name
        public void SortMembersDescendingName()
        {
            memberList = memberList.OrderByDescending(member => member.MemberName).ToList();
        }
    }
}