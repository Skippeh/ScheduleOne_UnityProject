namespace Funly.SkyStudio
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Camera))]
	public class RenderCloudCubemap : global::UnityEngine.MonoBehaviour
	{
		public enum CubemapTextureFormat
		{
			RGBColor = 0,
			RGBAColor = 1,
			RGBALit = 2
		}

		public const string kDefaultFilenamePrefix = "CloudCubemap";

		[global::UnityEngine.Tooltip("Filename of the final output cubemap asset. It will be written to the same directory as the current scene.")]
		public string filenamePrefix;

		[global::UnityEngine.Tooltip("Resolution of each face of the cubemap.")]
		public int faceWidth;

		[global::UnityEngine.Tooltip("Format for the exported cubemap. RGBColor (Additive texture), RGBAColor (Color with alpha channel), RGBANormal (Normal lighting data encoded).")]
		public global::Funly.SkyStudio.RenderCloudCubemap.CubemapTextureFormat textureFormat;

		public bool exportFaces;
	}
}
