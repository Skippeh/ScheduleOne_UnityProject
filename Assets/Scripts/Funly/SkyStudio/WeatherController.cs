using UnityEngine;

namespace Funly.SkyStudio
{
	public class WeatherController : MonoBehaviour
	{
		private WeatherEnclosure m_Enclosure;

		private MeshRenderer m_EnclosureMeshRenderer;

		private WeatherEnclosureDetector detector;

		private SkyProfile m_Profile;

		private float m_TimeOfDay;

		public RainDownfallController rainDownfallController { get; protected set; }

		public RainSplashController rainSplashController { get; protected set; }

		public LightningController lightningController { get; protected set; }

		public WeatherDepthCamera weatherDepthCamera { get; protected set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void DiscoverWeatherControllers()
		{
		}

		private void OnDisable()
		{
		}

		public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
		{
		}

		private void LateUpdate()
		{
		}

		private void OnEnclosureDidChange(WeatherEnclosure enclosure)
		{
		}
	}
}
