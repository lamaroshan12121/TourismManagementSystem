using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TourismManagementSystem.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        [Required]
        public int TouristId { get; set; }

        [Required]
        public int PackageId { get; set; }

        [Required]
        public int TourDateId { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "Number of participants must be between 1 and 1000")]
        public int NumberOfParticipants { get; set; }

        [Required]
        [RegularExpression(@"^(Pending|Confirmed|Completed|Cancelled)$")]
        public string BookingStatus { get; set; } = "Pending";

        [Required]
        public decimal TotalPrice { get; set; }

        public DateTime BookingDate { get; set; } = DateTime.Now;
        public DateTime? BookingCompletedDate { get; set; }

        // Navigation properties
        [ForeignKey("TouristId")]
        public virtual Tourist Tourist { get; set; }
        
        [ForeignKey("PackageId")]
        public virtual TourPackage TourPackage { get; set; }
        
        [ForeignKey("TourDateId")]
        public virtual TourDate TourDate { get; set; }
        
        public virtual Payment Payment { get; set; }
        public virtual Feedback Feedback { get; set; }
    }
}
