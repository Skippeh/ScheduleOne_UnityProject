namespace Funly.SkyStudio
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Camera))]
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Rendering.Universal.UniversalAdditionalCameraData))]
	public class URPWeatherDepth : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.RenderTexture renderTexture;

		private global::UnityEngine.Camera m_Camera;

		private global::UnityEngine.Rendering.Universal.UniversalAdditionalCameraData m_CameraData;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
