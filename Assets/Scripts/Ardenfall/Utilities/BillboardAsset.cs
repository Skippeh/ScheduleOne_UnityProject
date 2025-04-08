namespace Ardenfall.Utilities
{
	[global::UnityEngine.CreateAssetMenu(menuName = "Ardenfall/Foliage/Billboard Asset")]
	public class BillboardAsset : global::UnityEngine.ScriptableObject
	{
		public global::UnityEngine.GameObject prefab;

		public global::Ardenfall.Utilities.BillboardRenderSettings renderSettings;

		[global::UnityEngine.Header("Values")]
		public int textureSize;

		public float cutoff;

		[global::UnityEngine.Header("LODs")]
		public bool pickLastLOD;

		public int LODIndex;

		[global::UnityEngine.HideInInspector]
		public global::System.Collections.Generic.List<global::UnityEngine.Texture2D> generatedTextures;

		[global::UnityEngine.HideInInspector]
		public global::UnityEngine.Mesh generatedMesh;

		[global::UnityEngine.HideInInspector]
		public global::UnityEngine.Material generatedMaterial;

		[global::UnityEngine.HideInInspector]
		public global::UnityEngine.GameObject generatedPrefab;
	}
}
