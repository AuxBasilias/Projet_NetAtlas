using System.ComponentModel.DataAnnotations;

namespace NetAtlas.Models.Publication
{
    public class Message : Publication
    {
        [Required]
        public string? Text { get; set; }

    }
}
