using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertTestTask1.ViewModels
{
    public class CommViewModel
    {
        public string User { get; set; }

        public string Email { get; set; }

        public string OrderText { get; set; }

        public int CommissionPrice { get; set; }

        public bool CommTime { get; set; }

        public IFormFile Avatar { get; set; }

    }
}
