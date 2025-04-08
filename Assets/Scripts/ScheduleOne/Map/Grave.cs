namespace ScheduleOne.Map
{
	public class Grave : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public class GraveSuface
		{
			public global::UnityEngine.GameObject Object;

			public global::UnityEngine.MeshRenderer Mesh;

			public global::UnityEngine.Material[] Materials;
		}

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Map.Grave.GraveSuface[] Surfaces;

		public global::UnityEngine.GameObject[] HeadstoneObjects;

		public global::UnityEngine.MeshRenderer[] HeadstoneMeshes;

		public global::UnityEngine.Material[] HeadstoneMaterials;

		[global::EasyButtons.Button]
		public void RandomizeGrave()
		{
		}
	}
}
