namespace DAL.Entities
{
    public class StoryPage
    {
        public int PageNumber { get; set; }
        public string ChapterId { get; set; }
        public byte[] PageContent { get; set; }

        public Chapter Chapter { get; set; }
    }
}
