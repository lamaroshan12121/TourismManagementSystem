using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TourismManagementSystem.Models
{
    public class Agency
    {
        [Key]
        public int AgencyId { get; set; }

        [Required(ErrorMessage = "Agency name is required")]
        [StringLength(200)]
        public string AgencyName { get; set; }

        [Required(ErrorMessage = "User ID is required")]
        public int UserId { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }

        [StringLength(300)]
        public string Address { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;

        // Navigation properties
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public virtual ICollection<TourPackage> TourPackages { get; set; } = new List<TourPackage>();
    }
}
