namespace BookStore.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=ModelBookStore")
        {
        }

        public virtual DbSet<Arrival> Arrivals { get; set; }
        public virtual DbSet<ArrivalBook> ArrivalBooks { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookAuthor> BookAuthors { get; set; }
        public virtual DbSet<BookGenre> BookGenres { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Publishing> Publishings { get; set; }
        public virtual DbSet<Sell> Sells { get; set; }
        public virtual DbSet<SellBook> SellBooks { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arrival>()
                .Property(e => e.sum)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Arrival>()
                .HasMany(e => e.ArrivalBooks)
                .WithRequired(e => e.Arrival)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ArrivalBook>()
                .Property(e => e.price1pc)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Author>()
                .HasMany(e => e.BookAuthors)
                .WithRequired(e => e.Author)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.ArrivalBooks)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.BookAuthors)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.BookGenres)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.SellBooks)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.Warehouses)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Genre>()
                .HasMany(e => e.BookGenres)
                .WithRequired(e => e.Genre)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sell>()
                .Property(e => e.sum)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Sell>()
                .HasMany(e => e.SellBooks)
                .WithRequired(e => e.Sell)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SellBook>()
                .Property(e => e.price1pc)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Worker>()
                .HasMany(e => e.Arrivals)
                .WithRequired(e => e.Worker)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Worker>()
                .HasMany(e => e.Sells)
                .WithRequired(e => e.Worker)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Worker>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Worker)
                .WillCascadeOnDelete(false);
        }
    }
}
