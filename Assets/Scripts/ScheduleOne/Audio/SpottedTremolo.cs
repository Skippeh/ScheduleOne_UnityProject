namespace ScheduleOne.Audio
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Audio.AudioSourceController))]
	public class SpottedTremolo : global::UnityEngine.MonoBehaviour
	{
		private const float MinVolume = 0f;

		private const float MaxVolume = 1f;

		private const float MinPitch = 1.2f;

		private const float MaxPitch = 1.3f;

		private const float SmoothTime = 0.25f;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("PlayerVisibility")]
		private global::ScheduleOne.Vision.EntityVisibility _visibilityComponent;

		private global::ScheduleOne.Audio.AudioSourceController _audio;

		private float _targetIntensity;

		private float _smoothedIntensity;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
