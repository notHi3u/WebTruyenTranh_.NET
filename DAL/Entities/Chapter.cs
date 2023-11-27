namespace DAL.Entities
{
    public class Chapter
    {
        public string ChapterId { get; set; }
        public int StoryId { get; set; }
        public string ChapterName { get; set; }
        public int ChapterNumber { get; set; }

        public ICollection<StoryPage> Pages { get; set; }
        public Story Story { get; set; }
    }
}
