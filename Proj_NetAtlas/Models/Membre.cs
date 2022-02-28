using System.ComponentModel.DataAnnotations;

namespace NetAtlas.Models
{
    public class Membre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Nom { get; set; }
        [Required]
        public String Prenom { get; set; }
        [Required]
        public String Ad_email { get; set; }
    }

}
