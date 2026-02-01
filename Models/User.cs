using System;
using System.ComponentModel.DataAnnotations;

namespace TourismManagementSystem.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        [StringLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters")]
        public string PasswordHash { get; set; }

        [Required(ErrorMessage = "User type is required")]
        [RegularExpression(@"^(Agency|Tourist)$", ErrorMessage = "User type must be Agency or Tourist")]
        public string UserType { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;
    }
}
