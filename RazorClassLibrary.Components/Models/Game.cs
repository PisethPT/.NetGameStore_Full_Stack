namespace RazorClassLibrary.Components.Models;
public class Game
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Genre { get; set; }
    public decimal Price { get; set; }
    public DateOnly ReleaseDate { get; set; }
}

