using System.ComponentModel.DataAnnotations;

namespace Proiect_Cicioc_Daniela_Naomi.Models
{
    public class Laborant
    {
        public int ID { get; set; }

        [Display(Name = "Nume Laborant")]
        [Required(ErrorMessage = "Camp obligatoriu."), MinLength(5, ErrorMessage = "Numar minim de caractere: 5"), MaxLength(30, ErrorMessage = " Numar minim de caractere: 30")]
        public string Nume_Laborant { get; set; }

        [Display(Name = "Salar Brut Laborant")]
        [Required(ErrorMessage = "Camp obligatoriu."),]
        [Range(3000, 8000, ErrorMessage = "Valoare permisa: 30 - 5000")]
        public int Salar_Laborant { get; set; }


        [Display(Name = "Adresa Laborator")]
        public int? LaboratorID { get; set; }
        public Laborator? Laboratoare { get; set; }

        public ICollection<Analiza>? Analize { get; set; }


    }
}
