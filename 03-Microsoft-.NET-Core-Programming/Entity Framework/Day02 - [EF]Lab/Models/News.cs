
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day02____EF_Lab.Models
{
    public class News
    {
        [Key]
        public int NewsId { get; set; }
        [StringLength(50)]
        public string? Title { get; set; }
        [StringLength(100)]
        public string? Desc { get; set; }
        [StringLength(100)]
        public string? Breif { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public virtual Author? Author { get; set; }

    }
}
