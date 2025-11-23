using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Registration
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name must be under 100 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; } = string.Empty;
        [Range(1, int.MaxValue, ErrorMessage = "You must select an event")]
        public int EventId { get; set; }
    }
}
