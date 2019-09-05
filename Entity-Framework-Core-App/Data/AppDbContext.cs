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

            //Composite Key
            modelBuilder.Entity<Author>().HasKey(a => new {a.FirstName, a.LastName});
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ToDo> ToDoS { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
