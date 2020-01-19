namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Worker")]
    public partial class Worker
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Worker()
        {
            Arrivals = new HashSet<Arrival>();
            Sells = new HashSet<Sell>();
            Users = new HashSet<User>();
        }

        [Key]
        public int idWorker { get; set; }

        [Required]
        [StringLength(100)]
        public string fullName { get; set; }

        [Column(TypeName = "date")]
        public DateTime dateOfBirth { get; set; }

        [StringLength(100)]
        public string phoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string position { get; set; }

        [Required]
        public string address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Arrival> Arrivals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sell> Sells { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
