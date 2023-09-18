using System;
namespace EFDbRelationshipsExamples.Entities
{
	public class Weapon
	{
		public int Id { get; set; }

		public string Description { get; set; } = null!;

		public int CharacterId { get; set; }

		public Character Character { get; set; } = null!;
	}
}

