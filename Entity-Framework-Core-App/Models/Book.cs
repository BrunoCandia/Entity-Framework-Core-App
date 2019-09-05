using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Framework_Core_App.Models
{
    public class Book
    {
        public int Id { get; set; }                 //Primary key convention1 (Id)
        //public int BookId { get; set; }           //Primary key convention2 (ClassName + Id)

        //[Key]
        //public int BookIdentifier { get; set; }   //Primary key convention3 (DataAnnotation)

        [MaxLength(32)]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
    }
}
