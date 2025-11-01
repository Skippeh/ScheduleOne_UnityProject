namespace ScheduleOne.Vehicles
{
	public class Wheel : global::UnityEngine.MonoBehaviour
	{
		public const float SIDEWAY_SLIP_THRESHOLD = 0.2f;

		public const float FORWARD_SLIP_THRESHOLD = 0.8f;

		public const float DRIFT_AUDIO_THRESHOLD = 0.2f;

		public const float MIN_SPEED_FOR_DRIFT = 8f;

		public const float WHEEL_ANIMATION_DISTANCE = 40f;

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

		public float ForwardStiffnessMultiplier_Handbrake;

		public float SidewayStiffnessMultiplier_Handbrake;

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

		private global::UnityEngine.Transform wheelTransform;

		public bool isStatic { get; protected set; }

		public bool IsDrifting { get; protected set; }

		public bool IsDrifting_Smoothed => false;

		public float DriftTime { get; protected set; }

		public float DriftIntensity { get; protected set; }

		protected virtual void Start()
		{
		}

		public void FixedUpdateWheel()
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
