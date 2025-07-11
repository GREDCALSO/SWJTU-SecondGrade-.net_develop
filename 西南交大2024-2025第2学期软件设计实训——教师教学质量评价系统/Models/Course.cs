using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace 西南交大2024_2025第2学期软件设计实训__教师教学质量评价系统.Models
{
    [Table("Course")]
    internal class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int keyID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        public string Course_No { get; set; }

        [Required]
        [StringLength(20)]
        public string Semester { get; set; }

        [Required]
        [StringLength(20)]
        public string Teacher_No { get; set; }

        [Required]
        public int is_deleted { get; set; }
    }
}