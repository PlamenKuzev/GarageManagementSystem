using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace GarageManagementSystem.Models
{
    public class Owner
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = null!;

        [Phone]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [EmailAddress]
        [Display(Name = "Email Adress")]
        public string Email { get; set; }


        public ICollection<Car> Cars = new List<Car>();
    }
}
