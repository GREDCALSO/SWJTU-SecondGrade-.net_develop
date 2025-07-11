using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace 西南交大2024_2025第2学期软件设计实训__教师教学质量评价系统.Models
{
    [Table("TeacherEvaluationIndex")]
    internal class TeacherEvaluationIndex
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int keyID { get; set; }

        [Required]
        [StringLength(20)]
        public string Teacher_No { get; set; }

        [Required]
        [StringLength(20)]
        public string Course_No { get; set; }

        [Required]
        [StringLength(20)]
        public string Chara_No { get; set; }

        [Required]
        [StringLength(20)]
        public string College_No { get; set; }

        [Required]
        public DateTime EvalDate { get; set; }

        public decimal eval_TeachingDesign { get; set; }
        public decimal eval_Content { get; set; }
        public decimal eval_ClassOrganzation { get; set; }
        public decimal eval_TeachingAttitude { get; set; }
        public decimal eval_ProfessionQuality { get; set; }
        public decimal eval_ResearchDepth { get; set; }
        public decimal eval_StuEffect { get; set; }

        [StringLength(500)]
        public string eval_Comment { get; set; }

        [Required]
        public int is_deleted { get; set; }
    }
}