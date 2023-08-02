using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiDb.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(25)")]
        [MinLength(1)]
        [MaxLength(25)]
        public string FirstName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(55)")]
        [MinLength(1)]
        [MaxLength(55)]
        public string LastName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(12)")]
        [MinLength(9)]
        [MaxLength(12)]
        public string Number { get; set; } = null;
        [Required]
        public bool Gender { get; set; }
    }
}
