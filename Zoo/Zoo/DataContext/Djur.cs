namespace Zoo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Djur")]
    public partial class Djur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Djur()
        {
            BesökHosVeterinär = new HashSet<BesökHosVeterinär>();
            Föräldrar1 = new HashSet<Föräldrar>();
            Föräldrar2 = new HashSet<Föräldrar>();
        }

        public int DjurID { get; set; }

        [Required]
        [StringLength(30)]
        public string Namn { get; set; }

        public double Vikt { get; set; }

        public int? UrsprungslandID { get; set; }

        public int? DjurTypID { get; set; }

        public int? DjurArtID { get; set; }

        public int? BoendemiljöID { get; set; }

        public int? FöräldrarID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BesökHosVeterinär> BesökHosVeterinär { get; set; }

        public virtual Boendemiljö Boendemiljö { get; set; }

        public virtual DjurArt DjurArt { get; set; }

        public virtual DjurTyp DjurTyp { get; set; }

        public virtual Föräldrar Föräldrar { get; set; }

        public virtual Ursprungsland Ursprungsland { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Föräldrar> Föräldrar1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Föräldrar> Föräldrar2 { get; set; }
    }
}
