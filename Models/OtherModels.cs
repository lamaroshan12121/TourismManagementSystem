using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TourismManagementSystem.Models
{
    public class TourDate
    {
        [Key]
        public int TourDateId { get; set; }

        [Required]
        public int PackageId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "Available seats must be between 1 and 1000")]
        public int AvailableSeats { get; set; }

        public int BookedSeats { get; set; } = 0;

        [ForeignKey("PackageId")]
        public virtual TourPackage TourPackage { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }

    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }

        [Required]
        public int BookingId { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set; }

        [StringLength(1000)]
        public string Comments { get; set; }

        public DateTime FeedbackDate { get; set; } = DateTime.Now;

        [ForeignKey("BookingId")]
        public virtual Booking Booking { get; set; }
    }

    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        public int BookingId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        [RegularExpression(@"^(Pending|Completed|Failed)$")]
        public string PaymentStatus { get; set; } = "Pending";

        [StringLength(100)]
        public string PaymentMethod { get; set; } = "Credit Card";

        public DateTime PaymentDate { get; set; } = DateTime.Now;

        [ForeignKey("BookingId")]
        public virtual Booking Booking { get; set; }
    }
}
