using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Framework_Core_App.Models
{
    public class PersonalLibraryBook
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int PersonalLibraryId { get; set; }
        public PersonalLibrary PersonalLibrary { get; set; }
    }
}
