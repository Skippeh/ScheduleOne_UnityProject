namespace ScheduleOne.Lighting
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Light))]
	public class FlickeringLight : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Intensity Settings")]
		[global::UnityEngine.Tooltip("The minimum light intensity.")]
		public float minIntensity;

		[global::UnityEngine.Tooltip("The maximum light intensity.")]
		public float maxIntensity;

		[global::UnityEngine.Header("Color Settings")]
		[global::UnityEngine.Tooltip("Enable slight color shifts to simulate a warm flame.")]
		public bool enableColorShift;

		public global::UnityEngine.Color minColor;

		public global::UnityEngine.Color maxColor;

		[global::UnityEngine.Header("Flicker Speed")]
		[global::UnityEngine.Tooltip("How quickly the light flickers (lower is faster).")]
		public float flickerSpeed;

		private global::UnityEngine.Light lightSource;

		private float targetIntensity;

		private global::UnityEngine.Color targetColor;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateTargetValues()
		{
		}
	}
}
