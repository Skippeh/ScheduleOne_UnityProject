namespace ScheduleOne.Noise
{
	public class Listener : global::UnityEngine.MonoBehaviour
	{
		public delegate void HearingEvent(global::ScheduleOne.Noise.NoiseEvent nEvent);

		public static global::System.Collections.Generic.List<global::ScheduleOne.Noise.Listener> listeners;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.Range(0.1f, 5f)]
		public float Sensitivity;

		public global::UnityEngine.Transform HearingOrigin;

		public global::ScheduleOne.Noise.Listener.HearingEvent onNoiseHeard;

		public float SquaredHearingRange { get; protected set; }

		public void Awake()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void Notify(global::ScheduleOne.Noise.NoiseEvent nEvent)
		{
		}
	}
}
