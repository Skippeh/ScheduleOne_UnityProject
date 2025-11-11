namespace ScheduleOne.Vehicles
{
	public class Wheel : global::UnityEngine.MonoBehaviour
	{
		public const float SIDEWAY_SLIP_THRESHOLD = 0.2f;

		public const float FORWARD_SLIP_THRESHOLD = 0.8f;

		public const float DRIFT_AUDIO_THRESHOLD = 0.2f;

		public const float MIN_SPEED_FOR_DRIFT = 8f;

		public const float WHEEL_ANIMATION_DISTANCE = 40f;

		public const float HandbrakeFowardStiffnessMultiplier_Front = 0.9f;

		public const float HandbrakeSidewayStiffnessMultiplier_Front = 0.7f;

		public const float HandbrakeFowardStiffnessMultiplier_Rear = 0.9f;

		public const float HandbrakeSidewayStiffnessMultiplier_Rear = 0.3f;

		public bool DEBUG_MODE;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform wheelModel;

		public global::UnityEngine.Transform modelContainer;

		public global::UnityEngine.WheelCollider wheelCollider;

		public global::UnityEngine.Transform axleConnectionPoint;

		public global::UnityEngine.Collider staticCollider;

		public global::UnityEngine.ParticleSystem DriftParticles;

		[global::UnityEngine.Header("Settings")]
		public bool DriftParticlesEnabled;

		[global::UnityEngine.Header("Drift Audio")]
		public bool DriftAudioEnabled;

		public global::ScheduleOne.Audio.AudioSourceController DriftAudioSource;

		private float defaultForwardStiffness;

		private float defaultSidewaysStiffness;

		private global::ScheduleOne.Vehicles.LandVehicle vehicle;

		private global::UnityEngine.Vector3 lastFixedUpdatePosition;

		private global::UnityEngine.WheelHit wheelData;

		private global::UnityEngine.WheelFrictionCurve forwardCurve;

		private global::UnityEngine.WheelFrictionCurve sidewaysCurve;

		public bool IsDrifting { get; protected set; }

		public bool IsDrifting_Smoothed => false;

		public float DriftTime { get; protected set; }

		public float DriftIntensity { get; protected set; }

		public bool IsSteerWheel { get; set; }

		private void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		public void FixedUpdateWheel()
		{
		}

		public void FakeWheelRotation()
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

		public virtual void SetPhysicsEnabled(bool enabled)
		{
		}

		public bool IsWheelGrounded()
		{
			return false;
		}
	}
}
