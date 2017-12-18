namespace Zoo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Föräldrar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Föräldrar()
        {
            Djur = new HashSet<Djur>();
        }

        public int FöräldrarID { get; set; }

        public int? MammaID { get; set; }

        public int? PappaID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Djur> Djur { get; set; }

        public virtual Djur Djur1 { get; set; }

        public virtual Djur Djur2 { get; set; }
    }
}
