using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ���Ͻ���2024_2025��2ѧ��������ʵѵ__��ʦ��ѧ��������ϵͳ.Models
{
    [Table("TeacherTotalPoints")]
    internal class TeacherTotalPoints
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int keyID { get; set; }

        [Required]
        [StringLength(20)]
        public string Teacher_No { get; set; }

        [Required]
        [StringLength(20)]
        public string Semester { get; set; }

        [Required]
        [StringLength(20)]
        public string College_No { get; set; }

        [Required]
        public decimal TotalPoints { get; set; }

        [Required]
        public int is_deleted { get; set; }
    }
}