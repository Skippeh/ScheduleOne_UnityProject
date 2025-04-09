using System.Collections.Generic;
using UnityEngine;

namespace Ardenfall.Utilities
{
	[CreateAssetMenu(menuName = "Ardenfall/Foliage/Billboard Asset")]
	public class BillboardAsset : ScriptableObject
	{
		public GameObject prefab;

		public BillboardRenderSettings renderSettings;

		[Header("Values")]
		public int textureSize;

		public float cutoff;

		[Header("LODs")]
		public bool pickLastLOD;

		public int LODIndex;

		[HideInInspector]
		public List<Texture2D> generatedTextures;

		[HideInInspector]
		public Mesh generatedMesh;

		[HideInInspector]
		public Material generatedMaterial;

		[HideInInspector]
		public GameObject generatedPrefab;
	}
}
