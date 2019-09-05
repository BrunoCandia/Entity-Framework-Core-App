using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Framework_Core_App.Models
{
    public enum Genre
    {
        Regular,
        Silver,
        Gold
    }

    public class Membership
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime Initiated { get; set; }

        [Required]
        public Genre Genre { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
