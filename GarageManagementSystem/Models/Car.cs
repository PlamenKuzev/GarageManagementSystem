using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GarageManagementSystem.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Brand { get; set; }

        [Required]
        [StringLength(500)]
        public string IssueDescription { get; set; }

        public bool IsReady { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ArrivalDate { get; set; }


        [DataType(DataType.Date)]
        public DateTime? CompletionDate { get; set; }

        [Column(TypeName= "decimal(18,2)")]
        public decimal RepairPrice { get; set; }


        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
