using RazorClassLibrary.Components.Models;
using RazorClassLibrary.Components.Models.Dtos;

namespace RazorClassLibrary.Components.Services;
public interface IGameStoreService
{
    Task<List<Game>> GetAllGamesAsync();
    Task<NewGame> GetGameByIdAsync(int Id);
    Task AddGameAsync(NewGame newGame);
    Task UpdateGameAsync(NewGame newGame);
    Task DeleteGameAsync(int Id);

}

