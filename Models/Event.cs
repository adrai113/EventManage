using System;
using System.ComponentModel.DataAnnotations;
namespace EventManagement.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        [Range(0, 10000)]
        public int Capacity { get; set; }

        public int AvailableSeats { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

}
