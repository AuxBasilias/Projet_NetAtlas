using NetAtlas.Models.Publication;
using System.ComponentModel.DataAnnotations;

namespace NetAtlas.Models
{
    public class Membre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage ="Nom ne peut pas dépasser 40 caractères")]
        public String? Nom { get; set; }
        [Required]
        public String? Prenom { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",ErrorMessage="Format de l'email est invalide")]
        public String? Ad_email { get; set; }
        [Required]
        public String? MotPasse { get; set; }

        public ICollection<Membre>? Amis { get; set; }

        public ICollection<Publication.Publication>? Publications { get; set; }
    }

}
