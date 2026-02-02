using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace GarageManagementSystem.Models
{
    public class Owner
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; } = null!;

        [Phone]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }


        public ICollection<Car> Cars = new List<Car>();
    }
}
