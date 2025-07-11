using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ���Ͻ���2024_2025��2ѧ��������ʵѵ__��ʦ��ѧ��������ϵͳ.Models
{
    [Table("Mentor")]
    internal class Mentor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int keyID { get; set; }

        [Required]
        [StringLength(20)]
        public string Mentor_No { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int is_deleted { get; set; }
    }
}