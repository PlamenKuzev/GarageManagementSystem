using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GarageManagementSystem.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Brand")]
        public string Brand { get; set; } = null!;

        [Required]
        [StringLength(500)]
        [Display(Name = "Issue Description")]
        public string IssueDescription { get; set; } = null!;

        [Display(Name = "Status")]
        public bool IsReady { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Arrival Date")]
        public DateTime ArrivalDate { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "Completion Date")]
        public DateTime? CompletionDate { get; set; }

        [Column(TypeName= "decimal(18,2)")]
        [Display(Name = "Repair Price")]
        public decimal RepairPrice { get; set; }

        [Display(Name = "Owner")]
        public int OwnerId { get; set; }

        public Owner? Owner { get; set; }
    }
}
