using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluationSystem.Models
{
    [Table("EvaluationAssignment")]
    internal class EvaluationAssignment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int keyID { get; set; }

        [Required]
        [StringLength(20)]
        public string Chara_No { get; set; }

        [Required]
        [StringLength(20)]
        public string Teacher_No { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public int is_completed { get; set; }

        [Required]
        public int is_deleted { get; set; }
    }
}