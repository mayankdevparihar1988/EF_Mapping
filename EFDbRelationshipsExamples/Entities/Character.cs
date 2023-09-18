using System;
namespace EFDbRelationshipsExamples.Entities
{
	public class Character
	{
		public int Id { get; set; }

		public string Name { get; set; } = String.Empty;

		public Backpack BackPack { get; set; }

		public List<Weapon> Weapons { get; set; }

		public int FractionIdPk { get; set; }

		public List<Fraction> Fractions { get; set; }
	}
}

