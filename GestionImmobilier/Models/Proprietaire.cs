using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionImmobilier.Models
{
    public class Proprietaire:Utilisateur
    {


        [Required(ErrorMessage ="*"), MaxLength(100), Display(Name ="Nom Proprietaire")]

        public string NomProprio { get; set; }

        public virtual  ICollection<Bien> biens { get; set; }
    }
}