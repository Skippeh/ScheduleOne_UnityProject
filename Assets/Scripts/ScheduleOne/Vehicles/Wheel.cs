using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	public class Wheel : MonoBehaviour
	{
		public const float SIDEWAY_SLIP_THRESHOLD = 0.2f;

		public const float FORWARD_SLIP_THRESHOLD = 0.8f;

		public const float DRIFT_AUDIO_THRESHOLD = 0.2f;

		public const float MIN_SPEED_FOR_DRIFT = 8f;

		public const float WHEEL_ANIMATION_DISTANCE = 40f;

		public bool DEBUG_MODE;

		[Header("References")]
		public Transform wheelModel;

		public Transform modelContainer;

		public WheelCollider wheelCollider;

		public Transform axleConnectionPoint;

		public Collider staticCollider;

		public ParticleSystem DriftParticles;

		[Header("Settings")]
		public bool DriftParticlesEnabled;

		public float ForwardStiffnessMultiplier_Handbrake;

		public float SidewayStiffnessMultiplier_Handbrake;

		[Header("Drift Audio")]
		public bool DriftAudioEnabled;

		public AudioSourceController DriftAudioSource;

		private float defaultForwardStiffness;

		private float defaultSidewaysStiffness;

		private LandVehicle vehicle;

		private Vector3 lastFramePosition;

		private WheelHit wheelData;

		private WheelFrictionCurve forwardCurve;

		private WheelFrictionCurve sidewaysCurve;

		private Transform wheelTransform;

		public bool isStatic { get; protected set; }

		public bool IsDrifting { get; protected set; }

		public bool IsDrifting_Smoothed => false;

		public float DriftTime { get; protected set; }

		public float DriftIntensity { get; protected set; }

		protected virtual void Start()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		private void FixedUpdate()
		{
		}

		private void CheckDrifting()
		{
		}

		private void UpdateDriftEffects()
		{
		}

		private void UpdateDriftAudio()
		{
		}

		private void ApplyFriction()
		{
		}

		public virtual void SetIsStatic(bool s)
		{
		}

		private void GroundWheelModel()
		{
		}

		public bool IsWheelGrounded()
		{
			return false;
		}
	}
}
