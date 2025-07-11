using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluationSystem.Models
{
    [Table("CollogeAdmin")]
    internal class CollogeAdmin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int keyID { get; set; }

        [Required]
        [StringLength(20)]
        public string admin_No { get; set; }

        [Required]
        [StringLength(20)]
        public string College_No { get; set; }

        [Required]
        public int is_deleted { get; set; }
    }
}