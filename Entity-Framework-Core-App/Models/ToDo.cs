using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Framework_Core_App.Models
{
    public class ToDo : BaseEntity
    {
        [Required]
        public string Text { get; set; }
        [Required]
        public bool IsCompleted { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime CompletedAt { get; set; }
    }
}
