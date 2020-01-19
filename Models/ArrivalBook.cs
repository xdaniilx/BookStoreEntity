namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArrivalBook")]
    public partial class ArrivalBook
    {
        [Key]
        public int idArrivalBook { get; set; }

        public int idBook { get; set; }

        public int idArrival { get; set; }

        public int quantity { get; set; }

        public decimal price1pc { get; set; }

        public virtual Arrival Arrival { get; set; }

        public virtual Book Book { get; set; }
    }
}
