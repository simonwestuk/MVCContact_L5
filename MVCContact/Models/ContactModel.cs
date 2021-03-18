using System.ComponentModel.DataAnnotations;

namespace MVCContact.Models
{
    public class ContactModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(11)]
        public string Tel { get; set; }

        [EmailAddress]
        public string Owner { get; set; }

    }
}
