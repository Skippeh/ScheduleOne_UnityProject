namespace ScheduleOne.PlayerTasks
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.InputSystem.Accelerometer))]
	public class Pourable : global::ScheduleOne.PlayerTasks.Draggable
	{
		public global::System.Action onInitialPour;

		[global::UnityEngine.Header("Pourable settings")]
		public bool Unlimited;

		public float StartQuantity;

		public float PourRate_L;

		public float AngleFromUpToPour;

		[global::UnityEngine.Tooltip("Multiplier for pour rate when pourable is shaken up and down")]
		public float ShakeBoostRate;

		public bool AffectsCoverage;

		[global::UnityEngine.Header("Particles")]
		public float ParticleMinMultiplier;

		public float ParticleMaxMultiplier;

		[global::UnityEngine.Header("Pourable References")]
		public global::UnityEngine.ParticleSystem[] PourParticles;

		public global::UnityEngine.Transform PourPoint;

		public global::ScheduleOne.Audio.AudioSourceController PourLoop;

		[global::UnityEngine.Header("Trash")]
		public global::ScheduleOne.Trash.TrashItem TrashItem;

		[global::UnityEngine.HideInInspector]
		public global::ScheduleOne.Growing.GrowContainer TargetGrowContainer;

		protected bool hasPoured;

		protected bool autoSetCurrentQuantity;

		private float[] particleMinSizes;

		private float[] particleMaxSizes;

		private global::ScheduleOne.DevUtilities.AverageAcceleration accelerometer;

		public bool IsPouring { get; protected set; }

		public float NormalizedPourRate { get; private set; }

		public float CurrentQuantity { get; protected set; }

		protected virtual void Start()
		{
		}

		protected override void Update()
		{
		}

		protected override void FixedUpdate()
		{
		}

		protected virtual void UpdatePouring()
		{
		}

		private float GetShakeBoost()
		{
			return 0f;
		}

		protected virtual void PourAmount(float amount)
		{
		}

		protected bool IsPourPointOverPot()
		{
			return false;
		}

		protected virtual bool CanPour()
		{
			return false;
		}
	}
}
