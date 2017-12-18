namespace Zoo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MedicinTillDiagnos
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Benämning { get; set; }

        public int? DiagnosID { get; set; }

        public virtual Diagnos Diagnos { get; set; }
    }
}
