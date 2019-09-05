using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Framework_Core_App.Models
{
    public class Client
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(64)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(64)]
        public string Email { get; set; }

        [Required]
        [MaxLength(64)]
        public string PhoneNumber { get; set; }

        //Navigation properties

        public Membership Membership { get; set; }
    }
}
