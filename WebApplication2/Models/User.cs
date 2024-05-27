using System.ComponentModel.DataAnnotations;

namespace Practica.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string firstname { get; set; } = null!;
        public string lastname { get; set; } = null!;
        public string birthdate { get; set; }
    }
}
