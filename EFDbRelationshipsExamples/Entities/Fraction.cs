using System;
namespace EFDbRelationshipsExamples.Entities
{
	public class Fraction
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public int CharacterId { get; set; }

		public List<Character> Characters { get; set; }
		
	}
}

