using System.ComponentModel.DataAnnotations;

namespace Day02____EF_Lab.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Desc { get; set; }
        public virtual List<News> News { get; set; } = new List<News>();
    }
}
