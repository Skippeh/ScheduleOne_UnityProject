using System;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	[Serializable]
	public class CharacterElementsPreset
	{
		public string name;

		public Mesh[] mesh;

		public string[] hideParts;

		public float yOffset;

		public Material[] mats;
	}
}
