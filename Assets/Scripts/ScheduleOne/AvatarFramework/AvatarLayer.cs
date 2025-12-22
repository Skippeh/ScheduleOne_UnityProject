namespace ScheduleOne.AvatarFramework
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "Avatar Layer", menuName = "ScriptableObjects/Avatar Layer", order = 1)]
	public class AvatarLayer : global::UnityEngine.ScriptableObject
	{
		public string Name;

		public string AssetPath;

		public global::UnityEngine.Texture2D Texture;

		public global::UnityEngine.Texture2D Normal;

		public global::UnityEngine.Texture2D Normal_DefaultImportType;

		public int Order;

		public global::UnityEngine.Material CombinedMaterial;
	}
}
