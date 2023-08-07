using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PMS.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string UserId { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string UserName { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Password { get; set; } = "";

    }
}
