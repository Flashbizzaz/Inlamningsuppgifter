namespace Zoo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ursprungsland")]
    public partial class Ursprungsland
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ursprungsland()
        {
            Djur = new HashSet<Djur>();
        }

        public int UrsprungslandID { get; set; }

        [Required]
        [StringLength(30)]
        public string Benämning { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Djur> Djur { get; set; }
    }
}
