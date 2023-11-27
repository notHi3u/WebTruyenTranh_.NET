namespace DAL.Entities
{
    public class Post
    {
        public int UserId { get; set; }
        public int StoryId { get; set; }

        public User_Account User { get; set; }
        public Story Story { get; set; }
    }
}
