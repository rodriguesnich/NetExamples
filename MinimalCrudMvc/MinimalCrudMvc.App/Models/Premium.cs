using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MinimalCrudMvc.App.Models;

public class Premium
{
 [Key]
    [DisplayName("Premium ID")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Title is required")]
    [StringLength(80, ErrorMessage = "Title is too long")]
    [MinLength(5, ErrorMessage = "Title is too short")]
    [DisplayName("Premium Title")]
    public string Title { get; set; } = string.Empty;

    [DataType(DataType.DateTime)]
    // [GreaterThanToday]
    [DisplayName("Start Date")]
    public DateTime StartDate { get; set; }


    [DataType(DataType.DateTime)]
    [DisplayName("End Date")]
    public DateTime EndDate { get; set; }


    [DisplayName("Student")]
    [Required(ErrorMessage = "Student is required")]
    public int StudentId { get; set; }

    public Student? Student { get; set; }
}
