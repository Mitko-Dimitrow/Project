using System.ComponentModel.DataAnnotations;

namespace Zoro.Data.Model
{
	public class AnimeDetails
	{
		[Key]
		public Guid Id { get; set; }

		public string genre { get; set; }

		public string Status { get; set; }

		public int Duration { get; set; }

		public DateTime StartAiring { get; set; }

		public DateTime FinishedAiring { get; set; }

		public string Studious { get; set; }

		public string Producers { get; set; }

		public double MALScore { get; set; }

		public List<Cast> Cast { get; set; }


	}
}

