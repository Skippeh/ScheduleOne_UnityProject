using System;
using System.Collections.Generic;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	[Serializable]
	public class CharacterPart
	{
		public string name;

		public List<SkinnedMeshRenderer> skinnedMesh;
	}
}
