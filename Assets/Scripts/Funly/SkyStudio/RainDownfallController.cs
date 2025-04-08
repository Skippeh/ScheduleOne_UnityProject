namespace Funly.SkyStudio
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.AudioSource))]
	public class RainDownfallController : global::UnityEngine.MonoBehaviour, global::Funly.SkyStudio.ISkyModule
	{
		public global::UnityEngine.MeshRenderer rainMeshRenderer;

		public global::UnityEngine.Material rainMaterial;

		private global::UnityEngine.MaterialPropertyBlock m_PropertyBlock;

		private global::UnityEngine.AudioSource m_RainAudioSource;

		private float m_TimeOfDay;

		private global::Funly.SkyStudio.SkyProfile m_SkyProfile;

		public void SetWeatherEnclosure(global::Funly.SkyStudio.WeatherEnclosure enclosure)
		{
		}

		private void Update()
		{
		}

		public void UpdateForTimeOfDay(global::Funly.SkyStudio.SkyProfile skyProfile, float timeOfDay)
		{
		}
	}
}
