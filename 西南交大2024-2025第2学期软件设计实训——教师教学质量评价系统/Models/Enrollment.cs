using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluationSystem.Models
{
    [Table("Enrollment")]
    internal class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int keyID { get; set; }

        [Required]
        [StringLength(20)]
        public string Enroll_No { get; set; }

        [Required]
        [StringLength(20)]
        public string Stu_No { get; set; }

        [Required]
        [StringLength(20)]
        public string Course_No { get; set; }

        public decimal Grades { get; set; }

        [Required]
        public int is_deleted { get; set; }
    }
}