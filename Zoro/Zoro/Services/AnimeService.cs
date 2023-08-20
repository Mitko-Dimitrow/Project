using Microsoft.EntityFrameworkCore;
using Zoro.Contracts;
using Zoro.Data;
using Zoro.Data.Model;
using Zoro.Models;

namespace Zoro.Services
{
    public class AnimeService : IAnimeService
    {
        private readonly ZoroDbContext zoroDb;

        public AnimeService(ZoroDbContext zoroDb)
        {
            this.zoroDb = zoroDb;
        }

        public async Task<IEnumerable<AllAnimeViewModel>> GetAllMoviesAnime()
        {
            return await zoroDb.AnimeInfo.Where(a => a.Type == "MOVIE")
                .Select(anime => new AllAnimeViewModel
                {
                    Title = anime.Title,
                    Type = anime.Type,
                    Description = anime.Description,
                    Image = anime.Image,
                    TotalEpisodes = anime.TotalEpisodes
                }).ToListAsync();
        }

        public async Task<IEnumerable<AllAnimeViewModel>> GetAllTVSeriesAnime()
        {
            return await zoroDb.AnimeInfo.Where(a=>a.Type=="TV Series")
                 .Select(anime => new AllAnimeViewModel
                 {
                     Title=anime.Title,
                     Type= anime.Type,
                     Description=anime.Description,
                     Image=anime.Image,
                     TotalEpisodes=anime.TotalEpisodes
                 }).ToListAsync();
        }

        public async Task<AnimeEpisodesViewModel> GetAnimeEpisodes(string animeName)
        {
            var anime = zoroDb.AnimeInfo.Where(a => a.Title == animeName)
                .Select(a => new AnimeInfo { AnimeDetailsId = a.AnimeDetailsId }).ToList();

            var episodes = await zoroDb.AnimeDetails.Where(a => a.DetailsId == anime[0].AnimeDetailsId)
                .Select(e => new EpisodesViewModel
                { 

                    Url = e.Episodes[0].Url
                }).ToListAsync();


            var model = await zoroDb
                .AnimeInfo
                .Where(a => a.Title == animeName)
                .Select(a => new AnimeEpisodesViewModel
                {
                    Title = a.Title,
                    Description = a.Description,
                    Image = a.Image,
                    Episodes = episodes
                }).ToListAsync();

            var animeInfo = new AnimeEpisodesViewModel();

            animeInfo = model[0];

            return animeInfo;
        }
    }
}
