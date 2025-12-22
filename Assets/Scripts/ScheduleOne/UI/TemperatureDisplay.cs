namespace ScheduleOne.UI
{
	public class TemperatureDisplay : global::UnityEngine.MonoBehaviour
	{
		public const float MaxCameraDistance = 8f;

		public const float MinCameraDistance = 0.5f;

		public const float FadeInDistance = 2f;

		public const float FadeOutDistance = 0.25f;

		public bool UseColor;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Gradient _temperatureColorGradient;

		[global::UnityEngine.SerializeField]
		private global::TMPro.TextMeshPro _label;

		private global::System.Func<float> _getCelsiusTemperature;

		private global::System.Func<bool> _getIsVisible;

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdateCanvas()
		{
		}

		public void SetTemperatureGetter(global::System.Func<float> getCelsiusTemperature)
		{
		}

		public void SetVisibilityGetter(global::System.Func<bool> getIsVisible)
		{
		}

		public void SetEnabled(bool enabled)
		{
		}
	}
}
