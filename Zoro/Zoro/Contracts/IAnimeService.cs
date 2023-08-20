using Zoro.Models;

namespace Zoro.Contracts
{
    public interface IAnimeService
    {
        Task<IEnumerable<AllAnimeViewModel>> GetAllAnime();

        Task<AnimeEpisodesViewModel> GetAnimeEpisodes(string animeName);
    }
}
