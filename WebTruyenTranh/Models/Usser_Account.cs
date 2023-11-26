namespace WebTruyenTranh.Models
{
    public class Usser_Account
    {
        public int UserId { get; set; }
        public int PerId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public string FileName { get; set; }
    }
}
