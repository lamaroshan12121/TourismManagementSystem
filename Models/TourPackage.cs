using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TourismManagementSystem.Models
{
    public class TourPackage
    {
        [Key]
        public int PackageId { get; set; }

        [Required(ErrorMessage = "Package name is required")]
        [StringLength(200)]
        public string PackageName { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(1000)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        [Required]
        [Range(1, 365, ErrorMessage = "Duration must be between 1 and 365 days")]
        public int DurationDays { get; set; }

        [Required]
        public int AgencyId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;

        // Navigation properties
        public virtual Agency Agency { get; set; }
        public virtual ICollection<TourDate> TourDates { get; set; } = new List<TourDate>();
        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
