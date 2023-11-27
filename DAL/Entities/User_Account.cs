namespace DAL.Entities
{
    public class User_Account
    {
        public int UserId { get; set; }
        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public string FileName { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Report> Reports { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public ICollection<Chapter> Chapters { get; set; }

    }
}
