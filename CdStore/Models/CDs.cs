using System.ComponentModel.DataAnnotations;

namespace CdStore.Models
{
    public class CDs
    {
        [Key]
        public int CdId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string AuthorName { get; set; } = string.Empty;
        public int YearOfRelease { get; set; }
        public string Category { get; set; } = string.Empty;
    }
}