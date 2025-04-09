using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Vehicles.Sound
{
	public class VehicleSound : MonoBehaviour
	{
		public const float COLLISION_SOUND_COOLDOWN = 0.5f;

		public float VolumeMultiplier;

		[Header("References")]
		public AudioSourceController EngineStartSource;

		public AudioSourceController EngineIdleSource;

		public AudioSourceController EngineLoopSource;

		public AudioSourceController HandbrakeSource;

		public AudioSourceController HonkSource;

		public AudioSourceController ImpactSound;

		[Header("Impact Sounds")]
		public float MinCollisionMomentum;

		public float MaxCollisionMomentum;

		public float MinCollisionVolume;

		public float MaxCollisionVolume;

		public float MinCollisionPitch;

		public float MaxCollisionPitch;

		[Header("Engine Loop Settings")]
		public AnimationCurve EngineLoopPitchCurve;

		public float EngineLoopPitchMultiplier;

		public AnimationCurve EngineLoopVolumeCurve;

		private float currentIdleVolume;

		private float lastCollisionTime;

		private float lastCollisionMomentum;

		public LandVehicle Vehicle { get; private set; }

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

		private void OnCollision(Collision collision)
		{
		}
	}
}
