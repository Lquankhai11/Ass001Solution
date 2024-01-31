namespace BusinessObject
{
    public class MemberObject
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        // Custom constructor that takes values for all properties
        public MemberObject(int memberId, string memberName, string email, string password, string city, string country)
        {
            MemberID = memberId;
            MemberName = memberName;
            Email = email;
            Password = password;
            City = city;
            Country = country;
        }
    }

}