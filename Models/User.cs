namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [Key]
        [StringLength(100)]
        public string login { get; set; }

        [Required]
        [StringLength(100)]
        public string password { get; set; }

        public int idWorker { get; set; }

        public virtual Worker Worker { get; set; }
    }
}
