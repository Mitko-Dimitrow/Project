using Zoro.Models;

namespace Zoro.Contracts
{
    public interface IAnimeService
    {
        Task<IEnumerable<AllAnimeViewModel>> GetAllTVSeriesAnime();
        Task<IEnumerable<AllAnimeViewModel>> GetAllMoviesAnime();

        Task<AnimeEpisodesViewModel> GetAnimeEpisodes(string animeName);
    }
}
