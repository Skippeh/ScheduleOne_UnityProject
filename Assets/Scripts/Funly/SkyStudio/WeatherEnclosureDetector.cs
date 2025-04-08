namespace Funly.SkyStudio
{
	public class WeatherEnclosureDetector : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Tooltip("Default enclosure used when not inside the trigger of another enclosure area.")]
		public global::Funly.SkyStudio.WeatherEnclosure mainEnclosure;

		private global::System.Collections.Generic.List<global::Funly.SkyStudio.WeatherEnclosure> triggeredEnclosures;

		public global::Funly.SkyStudio.RainDownfallController rainController;

		public global::System.Action<global::Funly.SkyStudio.WeatherEnclosure> enclosureChangedCallback;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnTriggerEnter(global::UnityEngine.Collider other)
		{
		}

		private void OnTriggerExit(global::UnityEngine.Collider other)
		{
		}

		public void ApplyEnclosure()
		{
		}
	}
}
