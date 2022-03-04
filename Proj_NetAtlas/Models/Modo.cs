//modo => modérateur
using System.ComponentModel.DataAnnotations;

namespace NetAtlas.Models
{
    public class Modo
    {
        [Key]
        public int ModoId { get; set; }
        public String? Nom { get; set; }
        public String? MotPasse { get; set; }
       /* public int Avertir(Membre mbr)
        {
           int  i = 0;
            return i;
        }
        public void SupprimerMembre(Membre mbr) {
            if (Avertir(mbr) >= 3){ }
        }*/
    }
}
