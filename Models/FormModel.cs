using System;
using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class FormModel
    {
        [Required(ErrorMessage = "Nom requis")]
        public string? Nom { get; set; }

        [Required(ErrorMessage = "Prenom requis")]
        public string? Prenom { get; set; }

        [Required(ErrorMessage = "Le genre est requis")]
        public string? Genre { get; set; }

        [Required(ErrorMessage = "L'adresse est requise")]
        public string? Adresse { get; set; }

        [RegularExpression(@"^[0-9]{5}$", ErrorMessage = "Code postal invalide")]
        public string? CodePostal { get; set; }

        [Required(ErrorMessage = "La ville est requise")]
        public string? Ville { get; set; }

        [EmailAddress(ErrorMessage = "Email invalide")]
        public string? Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateFormation { get; set; }

        public string? TypeFormation { get; set; }

        public string? AvisCobol { get; set; }

        public string? AvisCSharp { get; set; }
    }
}


