using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GestionImmobilier.Models
{
    public class Utilisateur
    {

        [Key]

        public int idUtilisateur { get; set; }

        [Required(ErrorMessage = "*"), MaxLength(100), Display(Name = "Nom Utilisateur")]
        public string nomUtilisateur { get; set; }

        [Required(ErrorMessage = "*"), MaxLength(1000), Display(Name = "Login")]
        public string login { get; set; }

        [Required(ErrorMessage = "*"), MaxLength(1000), Display(Name = "Mot de passe ")]
        public string motPasse { get; set; }

    }
}