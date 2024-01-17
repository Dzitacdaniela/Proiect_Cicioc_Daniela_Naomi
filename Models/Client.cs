using System.ComponentModel.DataAnnotations;

namespace Proiect_Cicioc_Daniela_Naomi.Models
{
    public class Client
    {
        public int ID { get; set; }

        [Display(Name = "Nume Client")]
        [Required(ErrorMessage = "Camp obligatoriu."), MinLength(5, ErrorMessage = "Numar minim de caractere: 5"), MaxLength(30, ErrorMessage = " Numar minim de caractere: 30")]
        public string Nume_Client { get; set; }
        [Display(Name = "E-Mail Client")]
        [Required(ErrorMessage = "Camp obligatoriu."), MinLength(5, ErrorMessage = "Numar minim de caractere: 5"), MaxLength(30, ErrorMessage = " Numar minim de caractere: 30")]
        public string EMail_Client { get; set; }
        [Display(Name = "Denumire Analiza")]
        public int? AnalizeID { get; set; }
        public Analiza? Analize { get; set; }
        public ICollection<AnalizaClient>? AnalizaClient { get; set; }

        [Display(Name = "Adresa Laborator")]
        public int? LaboratorID { get; set; }
        public Laborator? Laboratoare { get; set; }

    }
}
