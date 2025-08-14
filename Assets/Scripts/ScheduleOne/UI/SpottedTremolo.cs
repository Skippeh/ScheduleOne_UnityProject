namespace ScheduleOne.UI
{
	public class SpottedTremolo : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Range(0f, 1f)]
		public float Intensity;

		public global::ScheduleOne.Audio.AudioSourceController Loop;

		public global::ScheduleOne.Vision.EntityVisibility PlayerVisibility;

		[global::UnityEngine.Header("Settings")]
		public float MinVolume;

		public float MaxVolume;

		public float MinPitch;

		public float MaxPitch;

		public float SmoothTime;

		[global::UnityEngine.Range(0f, 1f)]
		[global::UnityEngine.SerializeField]
		private float smoothedIntensity;

		public void Update()
		{
		}
	}
}
