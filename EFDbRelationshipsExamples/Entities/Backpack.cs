﻿using System;
namespace EFDbRelationshipsExamples.Entities
{
	public class Backpack
	{
		public int Id { get; set; }

		public string Description { get; set; }

		public int CharacterId { get; set; }

		public Character Character { get; set; }
	}
}

