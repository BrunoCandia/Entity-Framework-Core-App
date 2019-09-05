using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity_Framework_Core_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework_Core_App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(b => b.Isbn).HasMaxLength(10);

            //2 ways to define a Unique Field
            //Through Alternate Key
            //modelBuilder.Entity<Book>().HasAlternateKey(b => b.Isbn).HasName("UniqueIsbn");

            //Through Unique Index
            modelBuilder.Entity<Book>().HasIndex(b => b.Isbn).HasName("IsbnIndex").IsUnique();

            //Exclude a Property
            modelBuilder.Entity<Book>().Ignore(b => b.FullTitle);

            //Database Generated Value
            modelBuilder.Entity<Book>().Property(b => b.CreatedAt).HasDefaultValueSql("getdate()");

            //Shadow Property - Is defined in the DB but not in the model
            modelBuilder.Entity<Book>().Property<DateTime>("UpdatedAt").HasDefaultValueSql("getdate()");

            //Only 1 way to define a Composite Key
            //modelBuilder.Entity<Author>().HasKey(a => new {a.FirstName, a.LastName});

            //Author - Author Biography one-to-one relationship
            modelBuilder.Entity<Author>().HasOne(a => a.Biography).WithOne(ab => ab.Author).HasForeignKey<AuthorBiography>();

            //Book - PersonalLibrary many-to-many relationship
            //1 - Define a Composite Key
            //2 - Define a one-to-many relationship among PersonalLibraryBook and Book
            //3 - Define a one-to-many relationship among PersonalLibraryBook and PersonalLibrary
            modelBuilder.Entity<PersonalLibraryBook>().HasKey(plb => new {plb.BookId, plb.PersonalLibraryId});
            modelBuilder.Entity<PersonalLibraryBook>().HasOne(plb => plb.Book).WithMany(b => b.PersonalLibraryBooks).HasForeignKey(plb => plb.BookId);
            modelBuilder.Entity<PersonalLibraryBook>().HasOne(plb => plb.PersonalLibrary).WithMany(b => b.PersonalLibraryBooks).HasForeignKey(plb => plb.PersonalLibraryId);
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ToDo> ToDoS { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<AuthorBiography> AuthorBiographies { get; set; }
        public DbSet<PersonalLibrary> PersonalLibraries { get; set; }
        public DbSet<PersonalLibraryBook> PersonalLibraryBooks { get; set; }
    }
}
