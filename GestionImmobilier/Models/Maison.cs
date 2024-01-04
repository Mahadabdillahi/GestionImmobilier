using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionImmobilier.Models
{
    public class Maison:Bien
    {
        [Display(Name ="Nombre de chambre"), Required(ErrorMessage ="*")]

        public int NbreChambre { get; set; }


        [Display(Name = "Nombre salle d'eau"), Required(ErrorMessage = "*")]

        public int NbreSalleEau { get; set; }

        [Display(Name = "Nombre de cuisine"), Required(ErrorMessage = "*")]

        public int NbreCuisine { get; set; }

        [Display(Name = "Nombre de Toilette"), Required(ErrorMessage = "*")]

        public int NbreToilette { get; set; }

    }
}