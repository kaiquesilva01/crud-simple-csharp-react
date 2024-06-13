using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKaiqueCrud.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string name { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public int age { get; set; }
    }
}
