namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sell")]
    public partial class Sell
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sell()
        {
            SellBooks = new HashSet<SellBook>();
        }

        [Key]
        public int idSell { get; set; }

        public int idWorker { get; set; }

        public DateTime dateOfSale { get; set; }

        public decimal sum { get; set; }

        public virtual Worker Worker { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SellBook> SellBooks { get; set; }
    }
}
