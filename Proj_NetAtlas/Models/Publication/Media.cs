using System.ComponentModel.DataAnnotations;

namespace NetAtlas.Models.Publication
{
    public class Media:Publication
    {
        [Required]
        public int Taille { get; set; }


    }

   
}
