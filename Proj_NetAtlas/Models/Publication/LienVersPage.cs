using System.ComponentModel.DataAnnotations;

namespace NetAtlas.Models.Publication
{
    public class LienVersPage : Publication
    {
       
        public String? Titre { get; set; }
        [Required]
        public String? Url { get; set; }
    }
}
