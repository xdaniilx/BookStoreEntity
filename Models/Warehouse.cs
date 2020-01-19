namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Warehouse")]
    public partial class Warehouse
    {
        [Key]
        public int idWarehouse { get; set; }

        public int idBook { get; set; }

        public int quantity { get; set; }

        public decimal price { get; set; }

        public virtual Book Book { get; set; }
    }
}
