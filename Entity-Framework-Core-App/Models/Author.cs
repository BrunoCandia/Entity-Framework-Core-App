using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Framework_Core_App.Models
{
    public class Author
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        //Exclude a Property with DataAnnotations
        //By default EF Core will not include the property if a setter is not implemented
        //but if a setter is implemented the EF Core will include the property
        [NotMapped]
        public string FullName
        {
            get { return $"{FirstName} {MiddleName} {LastName}"; }
        }
        public DateTime DoB { get; set; }
        public string Nationality { get; set; }

        public AuthorBiography Biography { get; set; }
    }
}
