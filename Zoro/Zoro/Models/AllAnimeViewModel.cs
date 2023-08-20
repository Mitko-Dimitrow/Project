namespace Zoro.Models
{
    public class AllAnimeViewModel
    {
        public string Title { get; set; } = null!;

        public string Type { get; set; } = null!;

        public int TotalEpisodes { get; set; }

        public string Description { get; set; } = null!;

        public string Image { get; set; } = null!;
    }
}
