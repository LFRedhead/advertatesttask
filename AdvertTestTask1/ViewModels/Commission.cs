using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertTestTask1.ViewModels
{
    public class Commission
    {
        public int CommissionId { get; set; }

        [Required]
        public string CommUser { get; set; }

        [Required]
        [EmailAddress]
        public string CommEmail { get; set; }

        //[Required]
        //public string Password { get; set; }

        [Required]
        [StringLength(4096, MinimumLength = 10)]
        public string OrderText { get; set; }

        [Required]
        public int CommissionPrice { get; set; }

        [Required]
        public bool CommTime { get; set; }

       //[Required]
       // public byte[] Avatar { get; set; }

    }
}
