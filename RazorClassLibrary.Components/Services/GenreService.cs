using RazorClassLibrary.Components.Models;
using System.Net.Http.Json;

namespace RazorClassLibrary.Components.Services;
public class GenreService(HttpClient _httpClient) : IGenreService
{
	private const string BASE_URL = "https://pvmh9vmp-5017.asse.devtunnels.ms";
	private readonly HttpClient httpClient = _httpClient;
    public async Task<List<Genre>> GetGenreListAsync()
	{
		var response = await httpClient.GetAsync($"{BASE_URL}/genres");
		var genres = await response.Content.ReadFromJsonAsync<List<Genre>>();
		return genres!;
	}
}

