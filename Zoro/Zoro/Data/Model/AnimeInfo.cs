using System.ComponentModel.DataAnnotations;

namespace Zoro.Data.Model
{
    public class AnimeInfo
    {
        [Key]
        public Guid Id { get; set; }

        public string AnimeName { get; set; }

        public string genre { get; set; }

        public string Status { get; set; }

        public int Episodes { get; set; }
    }
}
