using System.ComponentModel.DataAnnotations;

namespace Zoro.Data.Model
{
    public class Episodes
    {
        [Key]
        public int EpisodeId { get; set; }
        [Required]
        public string Id { get; set; } = null!;
        [Required]
        public int Number { get; set; }
        [Required]
        public string Url { get; set; } = null!;
    }
}
