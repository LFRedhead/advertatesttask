using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertTestTask1.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Wrong E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Wrong password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
