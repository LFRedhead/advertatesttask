using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertTestTask1.Models
{
    public class Advert
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public string CustomerName { get; set; }
        public string CommDescription { get; set; }
        public int Price { get; set; }
        public bool IsTaken { get; set; }

    }
}
