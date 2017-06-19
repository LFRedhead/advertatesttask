using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertTestTask1.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "E-mail is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Wrong confirmation password.")]
        public string ConfirmPassword { get; set; }
    }
}
