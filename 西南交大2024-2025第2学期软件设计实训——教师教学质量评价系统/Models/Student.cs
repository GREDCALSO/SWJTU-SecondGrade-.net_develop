using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluationSystem.Models
{
    [Table("Student")]
    internal class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int keyID { get; set; }

        [Required]
        [StringLength(20)]
        public string Stu_No { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Major { get; set; }

        [Required]
        public int is_deleted { get; set; }
    }
}