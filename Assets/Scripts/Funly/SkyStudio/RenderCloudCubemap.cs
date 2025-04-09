using UnityEngine;

namespace Funly.SkyStudio
{
	[RequireComponent(typeof(Camera))]
	public class RenderCloudCubemap : MonoBehaviour
	{
		public enum CubemapTextureFormat
		{
			RGBColor = 0,
			RGBAColor = 1,
			RGBALit = 2
		}

		public const string kDefaultFilenamePrefix = "CloudCubemap";

		[Tooltip("Filename of the final output cubemap asset. It will be written to the same directory as the current scene.")]
		public string filenamePrefix;

		[Tooltip("Resolution of each face of the cubemap.")]
		public int faceWidth;

		[Tooltip("Format for the exported cubemap. RGBColor (Additive texture), RGBAColor (Color with alpha channel), RGBANormal (Normal lighting data encoded).")]
		public CubemapTextureFormat textureFormat;

		public bool exportFaces;
	}
}
