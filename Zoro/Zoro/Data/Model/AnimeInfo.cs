using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zoro.Data.Model
{
    public class AnimeInfo
    {
        [Key]
        public Guid Id { get; set; }

        public string AnimeName { get; set; }

        public string Type { get; set; }

        public int Episodes { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        [ForeignKey(nameof(AnimeDetails))]
        public Guid AnimeDetailsId { get; set; }

        public AnimeDetails AnimeDetails { get; set; }
    }
}
