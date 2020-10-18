using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CursoMVC.Models.ViewModels
{
    public class UserViewModel
    {
        
        [Required]
        [EmailAddress]
        [Display(Name ="Correo Electronico")] 
        [StringLength(100,ErrorMessage= "El {0} debe tener al menos {1} caracteres",MinimumLength=1)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
        [Display(Name = "Confirma Contraseña")]
        [Compare("Password",ErrorMessage = "Las contraseñas no son iguales")]
        public string ConfirmPassword { get; set; }
        [Required]
        public int Edad { get; set; }
    }

    public class EditUserViewModel
    {
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Correo Electronico")]
        [StringLength(100, ErrorMessage = "El {0} debe tener al menos {1} caracteres", MinimumLength = 1)]
        public string Email { get; set; }
        
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
        [Display(Name = "Confirma Contraseña")]
        [Compare("Password", ErrorMessage = "Las contraseñas no son iguales")]
        public string ConfirmPassword { get; set; }
        [Required]
        public int Edad { get; set; }
    }
}