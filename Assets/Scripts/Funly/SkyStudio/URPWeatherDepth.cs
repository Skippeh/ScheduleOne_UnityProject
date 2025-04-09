using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Funly.SkyStudio
{
	[RequireComponent(typeof(Camera))]
	[RequireComponent(typeof(UniversalAdditionalCameraData))]
	public class URPWeatherDepth : MonoBehaviour
	{
		public RenderTexture renderTexture;

		private Camera m_Camera;

		private UniversalAdditionalCameraData m_CameraData;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
