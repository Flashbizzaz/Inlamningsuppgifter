namespace Zoo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Diagnos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Diagnos()
        {
            BesökHosVeterinär = new HashSet<BesökHosVeterinär>();
            MedicinTillDiagnos = new HashSet<MedicinTillDiagnos>();
        }

        public int DiagnosID { get; set; }

        [StringLength(50)]
        public string Namn { get; set; }

        public string Beskrivning { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BesökHosVeterinär> BesökHosVeterinär { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicinTillDiagnos> MedicinTillDiagnos { get; set; }
    }
}
