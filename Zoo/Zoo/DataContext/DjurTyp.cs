namespace Zoo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DjurTyp")]
    public partial class DjurTyp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DjurTyp()
        {
            Djur = new HashSet<Djur>();
        }

        public int DjurTypID { get; set; }

        [StringLength(50)]
        public string Benämning { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Djur> Djur { get; set; }
    }
}
