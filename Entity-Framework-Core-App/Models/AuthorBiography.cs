using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Framework_Core_App.Models
{
    public class AuthorBiography
    {
        public int Id { get; set; }
        public string Biography { get; set; }

        //public string AuthorFirstName { get; set; }
        //public string AuthorLastName { get; set; }

        //Navigation properties

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
