using System.ComponentModel.DataAnnotations;

namespace NetAtlas.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String? Nom { get; set; }
        [Required]
        public String? MotDePasse { get; set; }
        public ICollection<Membre>? Membres { get; set; }

    }
}
