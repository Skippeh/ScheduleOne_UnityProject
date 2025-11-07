namespace ScheduleOne.Vehicles.Sound
{
	public class VehicleSound : global::UnityEngine.MonoBehaviour
	{
		public const float COLLISION_SOUND_COOLDOWN = 0.5f;

		public const float AUDIO_LERP_SPEED = 2f;

		public const float MinCollisionMomentum = 4000f;

		public const float MaxCollisionMomentum = 25000f;

		public const float MinCollisionVolume = 0.2f;

		public const float MaxCollisionVolume = 0.8f;

		public const float MinCollisionPitch = 0.6f;

		public const float MaxCollisionPitch = 1.1f;

		public float EngineVolumeMultiplier;

		public float EnginePitchMultiplier;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Audio.AudioSourceController EngineStartSource;

		public global::ScheduleOne.Audio.AudioSourceController EngineIdleSource;

		public global::ScheduleOne.Audio.AudioSourceController EngineLoopSource;

		public global::ScheduleOne.Audio.AudioSourceController HandbrakeSource;

		public global::ScheduleOne.Audio.AudioSourceController ImpactSound;

		[global::UnityEngine.Header("Engine Loop Settings")]
		public global::UnityEngine.AnimationCurve EngineLoopPitchCurve;

		public global::UnityEngine.AnimationCurve EngineLoopVolumeCurve;

		private float lastCollisionTime;

		private float lastCollisionMomentum;

		private global::UnityEngine.Coroutine volumeRoutine;

		public global::ScheduleOne.Vehicles.LandVehicle Vehicle { get; private set; }

		protected virtual void Awake()
		{
		}

		private void EngineStart()
		{
		}

		private void HandbrakeApplied()
		{
		}

		private void StartUpdateVolume()
		{
		}

		private void UpdateIdle(bool engineRunning)
		{
		}

		private void UpdateEngineLoop(bool engineRunning, float normalizedspeed)
		{
		}

		private void OnCollision(global::UnityEngine.Collision collision)
		{
		}
	}
}
