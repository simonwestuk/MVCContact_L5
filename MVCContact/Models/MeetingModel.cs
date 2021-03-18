using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCContact.Models
{
    public class MeetingModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }


        [Required]
        public string Notes { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        [EmailAddress]
        public string Owner { get; set; }


    }
}
