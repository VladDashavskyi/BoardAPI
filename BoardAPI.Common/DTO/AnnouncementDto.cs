using BoardAPI.Common.Enum;

namespace BoardAPI.Common.DTO
{
    public class AnnouncementDto
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
    }
}
