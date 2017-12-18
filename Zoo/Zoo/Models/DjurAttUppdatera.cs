using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Models
{
    public class DjurAttUppdatera
    {
        public int DjurID { get; set; }

        public string Namnet { get; set; }

        public double Vikten { get; set; }

        public int LandID { get; set; }

        public int TypID { get; set; }

        public int ArtID { get; set; }

        public int MiljöID { get; set; }

        public int FöräldrarID { get; set; }

        public int MammaID { get; set; }

        public int PappaID { get; set; }

    }
}
