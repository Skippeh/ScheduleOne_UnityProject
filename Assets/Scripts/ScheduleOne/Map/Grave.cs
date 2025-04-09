using System;
using EasyButtons;
using UnityEngine;

namespace ScheduleOne.Map
{
	public class Grave : MonoBehaviour
	{
		[Serializable]
		public class GraveSuface
		{
			public GameObject Object;

			public MeshRenderer Mesh;

			public Material[] Materials;
		}

		[Header("References")]
		public GraveSuface[] Surfaces;

		public GameObject[] HeadstoneObjects;

		public MeshRenderer[] HeadstoneMeshes;

		public Material[] HeadstoneMaterials;

		[Button]
		public void RandomizeGrave()
		{
		}
	}
}
