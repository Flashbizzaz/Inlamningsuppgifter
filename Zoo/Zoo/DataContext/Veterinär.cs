namespace Zoo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Veterinär
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Veterinär()
        {
            BesökHosVeterinär = new HashSet<BesökHosVeterinär>();
        }

        public int VeterinärID { get; set; }

        [StringLength(50)]
        public string Namn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BesökHosVeterinär> BesökHosVeterinär { get; set; }
    }
}
