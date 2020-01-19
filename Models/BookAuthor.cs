namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookAuthor")]
    public partial class BookAuthor
    {
        [Key]
        public int idBookAuthor { get; set; }

        public int idBook { get; set; }

        public int idAuthor { get; set; }

        public virtual Author Author { get; set; }

        public virtual Book Book { get; set; }
    }
}
