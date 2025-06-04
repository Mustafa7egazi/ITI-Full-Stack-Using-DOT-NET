using System.ComponentModel.DataAnnotations;

namespace Day02____EF_Lab.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(20)]
        public string Password { get; set; }

        public int Age { get; set; }

        public virtual List<News> News { get; set; } = new List<News>();

    }
}
