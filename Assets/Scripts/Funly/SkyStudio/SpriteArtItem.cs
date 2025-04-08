namespace Funly.SkyStudio
{
	public class SpriteArtItem : global::UnityEngine.ScriptableObject
	{
		public global::UnityEngine.Mesh mesh;

		public global::UnityEngine.Material material;

		public int rows;

		public int columns;

		public int totalFrames;

		public int animateSpeed;

		[global::UnityEngine.Tooltip("Color that will be multiplied against the base lightning bolt text color")]
		public global::UnityEngine.Color tintColor;
	}
}
