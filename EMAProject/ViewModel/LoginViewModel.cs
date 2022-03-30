using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace EMAProject.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "LOGIN")]
        public string UserName{get; set;}
        
        [Required]
        [UIHint("password")]
        [Display(Name = "Password")]
        public string UserPassword {get; set;}

        [Display(Name = "RememberMe")]
        public bool RememberMe {get; set;}

        
    }
}