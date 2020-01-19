namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            ArrivalBooks = new HashSet<ArrivalBook>();
            BookAuthors = new HashSet<BookAuthor>();
            BookGenres = new HashSet<BookGenre>();
            SellBooks = new HashSet<SellBook>();
            Warehouses = new HashSet<Warehouse>();
        }

        [Key]
        public int idBook { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        public int yearOfPublishing { get; set; }

        public int pageCount { get; set; }

        [Required]
        [StringLength(20)]
        public string ageLimit { get; set; }

        [Required]
        [StringLength(100)]
        public string ISBN { get; set; }

        public string cover { get; set; }

        [Required]
        [StringLength(100)]
        public string coverType { get; set; }

        [Required]
        public string description { get; set; }

        public int? idPublishing { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArrivalBook> ArrivalBooks { get; set; }

        public virtual Publishing Publishing { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookGenre> BookGenres { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SellBook> SellBooks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Warehouse> Warehouses { get; set; }
    }
}
