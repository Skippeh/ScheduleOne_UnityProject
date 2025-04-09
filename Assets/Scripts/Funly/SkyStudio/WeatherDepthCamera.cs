using UnityEngine;

namespace Funly.SkyStudio
{
	[RequireComponent(typeof(Camera))]
	public class WeatherDepthCamera : MonoBehaviour
	{
		private Camera m_DepthCamera;

		[Tooltip("Shader used to render out depth + normal texture. This should be the sky studio depth shader.")]
		public Shader depthShader;

		[HideInInspector]
		public RenderTexture overheadDepthTexture;

		[Tooltip("You can help increase performance by only rendering periodically some number of frames.")]
		[Range(1f, 60f)]
		public int renderFrameInterval;

		[Tooltip("The resolution of the texture. Higher resolution uses more rendering time but makes more precise weather along edges.")]
		[Range(128f, 8192f)]
		public int textureResolution;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void RenderOverheadCamera()
		{
		}

		private void PrepareRenderTexture()
		{
		}
	}
}
