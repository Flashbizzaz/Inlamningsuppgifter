namespace Zoo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BesökHosVeterinär
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DatumförBesök { get; set; }

        public TimeSpan? TidFörBesök { get; set; }

        public int? DjurID { get; set; }

        public int? VeterinärID { get; set; }

        public int? DiagnosID { get; set; }

        public virtual Diagnos Diagnos { get; set; }

        public virtual Djur Djur { get; set; }

        public virtual Veterinär Veterinär { get; set; }
    }
}
