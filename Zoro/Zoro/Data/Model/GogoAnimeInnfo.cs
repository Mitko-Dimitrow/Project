using System.ComponentModel.DataAnnotations;

namespace Zoro.Data.Model
{
    public class GogoAnimeInnfo
    {
        [Key]
        public int AnimeId { get; set; }
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Url { get; set; } = null!;

        [Required]
        public string Image { get; set; } = null!;

        public string? ReleaseDate { get; set; }

        public string? Description { get; set; }

        [Required]
        public string[] Genres { get; set; } = null!;

        [Required]
        public string SubOrDub { get; set; } = null!;

        public string? Type { get; set; }

        [Required]
        public string Status { get; set; } = null!;

        public string? OtherName { get; set; }

        [Required]
        public int TotalEpisodes { get; set; }

        [Required]
        public List<Episodes> Episodes { get; set; } = null!;


    }
}
