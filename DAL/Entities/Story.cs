namespace DAL.Entities
{
    public class Story
    {
        public int StoryId { get; set; }
        public string Title { get; set; }
        public DateTime UploadDate { get; set; }
        public float Rating { get; set; }
        public string Cover { get; set; }
        public int Favorite { get; set; }
        public string Author { get; set; }
        public string Summary { get; set; }
        public string Status { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<Find> Finds { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Report> Reports { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public ICollection<Chapter> Chapters { get; set; }
    }
}
