namespace ScheduleOne.Vehicles.Sound
{
	public class VehicleSound : global::UnityEngine.MonoBehaviour
	{
		public const float COLLISION_SOUND_COOLDOWN = 0.5f;

		public float VolumeMultiplier;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Audio.AudioSourceController EngineStartSource;

		public global::ScheduleOne.Audio.AudioSourceController EngineIdleSource;

		public global::ScheduleOne.Audio.AudioSourceController EngineLoopSource;

		public global::ScheduleOne.Audio.AudioSourceController HandbrakeSource;

		public global::ScheduleOne.Audio.AudioSourceController HonkSource;

		public global::ScheduleOne.Audio.AudioSourceController ImpactSound;

		[global::UnityEngine.Header("Impact Sounds")]
		public float MinCollisionMomentum;

		public float MaxCollisionMomentum;

		public float MinCollisionVolume;

		public float MaxCollisionVolume;

		public float MinCollisionPitch;

		public float MaxCollisionPitch;

		[global::UnityEngine.Header("Engine Loop Settings")]
		public global::UnityEngine.AnimationCurve EngineLoopPitchCurve;

		public float EngineLoopPitchMultiplier;

		public global::UnityEngine.AnimationCurve EngineLoopVolumeCurve;

		private float currentIdleVolume;

		private float lastCollisionTime;

		private float lastCollisionMomentum;

		public global::ScheduleOne.Vehicles.LandVehicle Vehicle { get; private set; }

		protected virtual void Awake()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		private void UpdateIdle()
		{
		}

		protected void HandbrakeApplied()
		{
		}

		protected void EngineStart()
		{
		}

		public void Honk()
		{
		}

		private void OnCollision(global::UnityEngine.Collision collision)
		{
		}
	}
}
