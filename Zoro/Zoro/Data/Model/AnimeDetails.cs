﻿using System.ComponentModel.DataAnnotations;

namespace Zoro.Data.Model
{
	public class AnimeDetails
	{
		[Key]
		public Guid Id { get; set; }

		[Required] 
		public string[] genre { get; set; } = null!;

		[Required] 
		public string Status { get; set; } = null!;
		[Required]
		public string ReleaseDate { get; set; } = null!;

		[Required]
        public List<Episodes> Episodes { get; set; } = null!;

        public List<Cast>? Cast { get; set; }


	}
}

