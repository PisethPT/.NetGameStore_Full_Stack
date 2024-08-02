using RazorClassLibrary.Components.Models;

namespace RazorClassLibrary.Components.Services;
public interface IGenreService
{
	Task<List<Genre>> GetGenreListAsync();
}

