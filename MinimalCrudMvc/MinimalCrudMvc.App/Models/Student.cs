using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MinimalCrudMvc.App.Models;

public class Student
{
    [Key]
    [DisplayName("Student ID")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(80, ErrorMessage = "Name is too long")]
    [MinLength(5, ErrorMessage = "Name is too short")]
    [DisplayName("Student Name")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    [DisplayName("Student Email")]
    public string Email { get; set; } = string.Empty;

    public List<Premium> Premiums { get; set; } = new();
}
