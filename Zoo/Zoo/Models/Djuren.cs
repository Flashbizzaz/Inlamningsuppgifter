using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Models
{
    public class Djuren
    {
        public int DjurID { get; set; }

        public string Namnet { get; set; }

        public double Vikten { get; set; }

        public string Ursprungslandet { get; set; }

        public string DjurTypen { get; set; }

        public string DjurArten { get; set; }

        public string Boendemiljön { get; set; }

        public string Förälder1 { get; set; }
        public string Förälder2 { get; set; }
    }
}
