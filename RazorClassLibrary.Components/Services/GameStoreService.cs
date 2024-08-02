using RazorClassLibrary.Components.Models;
using RazorClassLibrary.Components.Models.Dtos;
using RazorClassLibrary.Components.Services;
using System.Net.Http.Json;

namespace GameStore.HybridApp.Services;
public class GameStoreService : IGameStoreService
{
    private const string BASE_URL = "https://pvmh9vmp-5017.asse.devtunnels.ms/games";
	private const string DevTunnel = "https://0b7b6dnj-5017.asse.devtunnels.ms/games";

	private readonly HttpClient httpClient;

    public GameStoreService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

	public async Task AddGameAsync(NewGame newGame) => await httpClient.PostAsJsonAsync($"{BASE_URL}/add", newGame);

	public async Task DeleteGameAsync(int Id) => await httpClient.DeleteAsync($"{BASE_URL}/delete/{Id}");

	public async Task<List<Game>> GetAllGamesAsync()
    {
        var response = await httpClient.GetAsync($"{BASE_URL}");
        List<Game>? games = await response.Content.ReadFromJsonAsync<List<Game>>();
        return games!;
    }

	public async Task<NewGame> GetGameByIdAsync(int Id)
	{
		var response = await httpClient.GetAsync($"{BASE_URL}/{Id}");
		var game = await response.Content.ReadFromJsonAsync<GameDto>();

		return new NewGame()
		{
			Id = game!.Id,
			Name = game.Name,
			GenreId = game.GenreId,
			Price = game.Price,
			ReleaseDate = game.ReleaseDate
		};
	}

	public async Task UpdateGameAsync(NewGame updateGame) => await httpClient.PutAsJsonAsync($"{BASE_URL}/update/{updateGame.Id}", updateGame);
}
