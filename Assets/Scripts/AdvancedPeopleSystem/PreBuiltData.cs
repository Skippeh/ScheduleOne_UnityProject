using System;
using System.Collections.Generic;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	[Serializable]
	public class PreBuiltData
	{
		[SerializeField]
		public string GroupName;

		[SerializeField]
		public List<Mesh> meshes;

		[SerializeField]
		public List<Material> materials;
	}
}
