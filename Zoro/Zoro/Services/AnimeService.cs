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


        public async Task<IEnumerable<AllAnimeViewModel>> GetAllAnime()
        {
            return await zoroDb.AnimeInfo
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
            var episodes = await zoroDb.AnimeInfo.Where(a=>a.Title==animeName)
                .Select(e => new Episodes
                {
                    Number = e.AnimeDetails.Episodes,
                    Url = e.Url
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
