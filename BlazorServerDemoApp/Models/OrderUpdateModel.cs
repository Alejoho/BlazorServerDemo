using System.ComponentModel.DataAnnotations;

namespace BlazorServerDemoApp.Models;

public class OrderUpdateModel
{
    [Required(ErrorMessage = "The 'Ordered by' field is required.")]
    [MaxLength(20, ErrorMessage = "The 'Ordered by' should be less than 20 characters")]
    [MinLength(3, ErrorMessage = "The 'Ordered by' should have at least 3 characters")]
    public string NewName { get; set; } = string.Empty;
}