using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zoro.Data.Model
{
    public class AnimeInfo
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string AnimeName { get; set; } = null!;

        [Required] 
        public string Type { get; set; } = null!;

        [Required]
        public int Episodes { get; set; }

        [Required]
        public string Description { get; set; } = null!;

        [Required] 
        public string Image { get; set; } = null!;

        [ForeignKey(nameof(AnimeDetails))]
        public Guid AnimeDetailsId { get; set; }

        public AnimeDetails AnimeDetails { get; set; } = null!;
    }
}
