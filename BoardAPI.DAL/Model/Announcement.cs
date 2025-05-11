namespace BoardAPI.DAL.Model
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
    }
}
