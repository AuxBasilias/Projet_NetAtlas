using System.ComponentModel.DataAnnotations;

namespace NetAtlas.Models.Publication
{
    public class Publication
    {
        [Key]
        public int PubId { get; set; }
        [Required]
        public string? Nom { get; set; }
      
    }
}
