namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SellBook")]
    public partial class SellBook
    {
        [Key]
        public int idSellBook { get; set; }

        public int idBook { get; set; }

        public int idSell { get; set; }

        public int quantity { get; set; }

        public decimal price1pc { get; set; }

        public virtual Book Book { get; set; }

        public virtual Sell Sell { get; set; }
    }
}
