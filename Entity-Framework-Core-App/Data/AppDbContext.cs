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

            //Only 1 way to define a Composite Key
            modelBuilder.Entity<Author>().HasKey(a => new {a.FirstName, a.LastName});
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ToDo> ToDoS { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
