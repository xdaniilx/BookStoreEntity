namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Arrival")]
    public partial class Arrival
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Arrival()
        {
            ArrivalBooks = new HashSet<ArrivalBook>();
        }

        [Key]
        public int idArrival { get; set; }

        public int idWorker { get; set; }

        public DateTime dateOfArrival { get; set; }

        public decimal sum { get; set; }

        public virtual Worker Worker { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArrivalBook> ArrivalBooks { get; set; }
    }
}
