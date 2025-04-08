namespace Funly.SkyStudio
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Camera))]
	public class WeatherDepthCamera : global::UnityEngine.MonoBehaviour
	{
		private global::UnityEngine.Camera m_DepthCamera;

		[global::UnityEngine.Tooltip("Shader used to render out depth + normal texture. This should be the sky studio depth shader.")]
		public global::UnityEngine.Shader depthShader;

		[global::UnityEngine.HideInInspector]
		public global::UnityEngine.RenderTexture overheadDepthTexture;

		[global::UnityEngine.Tooltip("You can help increase performance by only rendering periodically some number of frames.")]
		[global::UnityEngine.Range(1f, 60f)]
		public int renderFrameInterval;

		[global::UnityEngine.Tooltip("The resolution of the texture. Higher resolution uses more rendering time but makes more precise weather along edges.")]
		[global::UnityEngine.Range(128f, 8192f)]
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
