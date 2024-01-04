using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionImmobilier.Models
{
    public class Appartement:Bien
    {
        [Display(Name = "Nombre de salle"), Required(ErrorMessage = "*")]

        public int Nombredesalle { get; set; }
    }
}