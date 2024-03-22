using System.ComponentModel.DataAnnotations;

namespace Mission11_Nieves.Models
{
    public class Book
    {
        [Key]
        [Required]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public string Classification { get; set; }
        public string Category { get; set; }
        public int PageCount { get; set; }
        public Single Price { get; set; }
    }
}
