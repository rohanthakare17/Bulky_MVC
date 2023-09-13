using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(20)]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,20, ErrorMessage = "Display order must be between 1-20")]
        public int DisplayOrder { get; set; } 
    }
}
