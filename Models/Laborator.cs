using System.ComponentModel.DataAnnotations;

namespace Proiect_Cicioc_Daniela_Naomi.Models
{
    public class Laborator
    {
        public int ID { get; set; }

        [Display(Name = "Denumire Laborator")]
        [Required(ErrorMessage = "Camp obligatoriu."), MinLength(5, ErrorMessage = "Numar minim de caractere: 5"), MaxLength(30, ErrorMessage = " Numar minim de caractere: 30")]
        public string Denumire_Laborator { get; set; }
        [Display(Name = "Adresa Laborator")]
        [Required(ErrorMessage = "Camp obligatoriu."), MinLength(5, ErrorMessage = "Numar minim de caractere: 5"), MaxLength(30, ErrorMessage = " Numar minim de caractere: 30")]
        public string Adresa_Laborator { get; set; }
        public Laborant? Laboranti { get; set; }
        public ICollection<Client>? Clienti { get; set; }

    }
}
