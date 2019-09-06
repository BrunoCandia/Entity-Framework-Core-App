using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity_Framework_Core_App.Models;
using Microsoft.EntityFrameworkCore.Internal;

namespace Entity_Framework_Core_App.Data
{
    public static class AppDbContextExtension
    {
        public static void EnsureDatabaseSeeded(this AppDbContext context)
        {
            if (!context.Authors.Any())
            {
                context.Authors.AddRange(new Author[]
                {
                    new Author{ FirstName = "John", LastName = "Smith", DoB = new DateTime(1980, 2, 5), Nationality = "Italy" },
                    new Author{ FirstName = "Jane", LastName = "Doe", DoB = new DateTime(1977, 1, 30) }
                });

                context.SaveChanges();
            }

            if (!context.Books.Any())
            {
                var author1 = context.Authors.SingleOrDefault(a => a.FirstName.Equals("John") && a.LastName.Equals("Smith"));
                var author2 = context.Authors.SingleOrDefault(a => a.FirstName.Equals("Jane") && a.LastName.Equals("Doe"));

                context.Books.AddRange(new Book[]
                {
                    new Book{ AuthorId = author1.Id, Isbn = "11111", Title = "Book1" },
                    new Book{ AuthorId = author2.Id, Isbn = "22222", Title = "Book2" }
                });

                context.SaveChanges();
            }
        }
    }
}
