namespace DAL.Entities
{
    public class Find
    {
        public int StoryId { get; set; }
        public int TagId { get; set; }

        public Story Story { get; set; }
        public HashTag Tag { get; set; }
    }
}
