using System.ComponentModel.DataAnnotations;

namespace ContactManagerLanMar.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [MaxLength(200)]
        public string CompanyName { get; set; }

        [Phone]
        public string Mobile { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}