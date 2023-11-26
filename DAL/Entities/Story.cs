namespace WebTruyenTranh.Models
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
    }
}
