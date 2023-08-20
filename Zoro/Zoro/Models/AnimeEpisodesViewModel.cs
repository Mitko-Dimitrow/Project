using Zoro.Data.Model;

namespace Zoro.Models
{
    public class AnimeEpisodesViewModel
    {

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Image { get; set; } = null!;

        public List<EpisodesViewModel> Episodes { get; set; }
    }
}
