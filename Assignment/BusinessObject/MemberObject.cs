namespace BusinessObject
{
    public class MemberObject : IComparable<MemberObject>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int CompareTo(MemberObject other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}