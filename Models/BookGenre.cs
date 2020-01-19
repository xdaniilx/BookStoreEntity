namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookGenre")]
    public partial class BookGenre
    {
        [Key]
        public int idBookGenre { get; set; }

        public int idBook { get; set; }

        public int idGenre { get; set; }

        public virtual Book Book { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
