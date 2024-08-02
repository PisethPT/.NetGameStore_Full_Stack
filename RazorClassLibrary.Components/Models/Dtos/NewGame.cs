using System.ComponentModel.DataAnnotations;

namespace RazorClassLibrary.Components.Models.Dtos;
public class NewGame
{
	public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public required string Name { get; set; }
    [Required(ErrorMessage = "The Genre Field is required.")]
    public int GenreId { get; set; }
    [Range(1, 100)]
    public decimal Price { get; set; }
    public DateOnly ReleaseDate { get; set; }
}

