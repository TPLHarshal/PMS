using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PMS.Models
{
    public class Project
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string? Project_Id { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string? Project_Name { get; set; } = "";

        [DataType(DataType.Date)]
        public DateTime? Start_Time_Plan { get; set; }

        [DataType(DataType.Date)]
        public DateTime? End_Time_Plan { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Reasons { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Type { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Division { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Category { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Priority { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Department { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Location { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Status { get; set; }

      
    }
}
