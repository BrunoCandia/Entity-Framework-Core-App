using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Framework_Core_App.Models
{
    public class PersonalLibrary
    {
        [Required]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

        //Navigation properties

        public List<PersonalLibraryBook> PersonalLibraryBooks { get; set; }
    }
}
