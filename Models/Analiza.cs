using System.ComponentModel.DataAnnotations;

namespace Proiect_Cicioc_Daniela_Naomi.Models
{
    public class Analiza
    {
        public int ID { get; set; }
        [Display(Name = "Denumire Analiza")]
        [Required(ErrorMessage = "Camp obligatoriu."), MinLength(2, ErrorMessage = "Numar minim de caractere: 2"), MaxLength(30, ErrorMessage = " Numar minim de caractere: 30")]
        public string Denumire_Analiza { get; set; }

        [Display(Name = "Pret Analiza")]
        [Required(ErrorMessage = "Camp obligatoriu."),]
        [Range(30, 5000, ErrorMessage = "Valoare permisa: 30 - 5000")]
        public int Pret_Analiza { get; set; }
        public ICollection<AnalizaClient>? AnalizaClient { get; set; }
        public int? LaborantID { get; set; }
        public Laborant? Laboranti { get; set; }

    }
}
