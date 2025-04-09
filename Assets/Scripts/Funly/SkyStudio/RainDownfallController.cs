using UnityEngine;

namespace Funly.SkyStudio
{
	[RequireComponent(typeof(AudioSource))]
	public class RainDownfallController : MonoBehaviour, ISkyModule
	{
		public MeshRenderer rainMeshRenderer;

		public Material rainMaterial;

		private MaterialPropertyBlock m_PropertyBlock;

		private AudioSource m_RainAudioSource;

		private float m_TimeOfDay;

		private SkyProfile m_SkyProfile;

		public void SetWeatherEnclosure(WeatherEnclosure enclosure)
		{
		}

		private void Update()
		{
		}

		public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
		{
		}
	}
}
