using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Models
{
    public class BokadeBesök
    {
        public int besökID { get; set; }

        public int djurid { get; set; }

        public string veterinärNamn { get; set; }

        public TimeSpan Tid { get; set; }
        public DateTime Datum { get; set; }

    }
}
