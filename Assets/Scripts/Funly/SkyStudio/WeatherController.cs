namespace Funly.SkyStudio
{
	public class WeatherController : global::UnityEngine.MonoBehaviour
	{
		private global::Funly.SkyStudio.WeatherEnclosure m_Enclosure;

		private global::UnityEngine.MeshRenderer m_EnclosureMeshRenderer;

		private global::Funly.SkyStudio.WeatherEnclosureDetector detector;

		private global::Funly.SkyStudio.SkyProfile m_Profile;

		private float m_TimeOfDay;

		public global::Funly.SkyStudio.RainDownfallController rainDownfallController { get; protected set; }

		public global::Funly.SkyStudio.RainSplashController rainSplashController { get; protected set; }

		public global::Funly.SkyStudio.LightningController lightningController { get; protected set; }

		public global::Funly.SkyStudio.WeatherDepthCamera weatherDepthCamera { get; protected set; }

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

		public void UpdateForTimeOfDay(global::Funly.SkyStudio.SkyProfile skyProfile, float timeOfDay)
		{
		}

		private void LateUpdate()
		{
		}

		private void OnEnclosureDidChange(global::Funly.SkyStudio.WeatherEnclosure enclosure)
		{
		}
	}
}
