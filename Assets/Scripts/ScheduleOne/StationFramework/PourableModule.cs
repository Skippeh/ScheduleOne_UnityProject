namespace ScheduleOne.StationFramework
{
	public class PourableModule : global::ScheduleOne.StationFramework.ItemModule
	{
		[global::UnityEngine.Header("Settings")]
		public string LiquidType;

		public float PourRate;

		public float AngleFromUpToPour;

		public bool OnlyEmptyOverFillable;

		public float LiquidCapacity_L;

		public global::UnityEngine.Color LiquidColor;

		public float DefaultLiquid_L;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.ParticleSystem[] PourParticles;

		public global::UnityEngine.Transform PourPoint;

		public global::ScheduleOne.StationFramework.LiquidContainer LiquidContainer;

		public global::ScheduleOne.PlayerTasks.Draggable Draggable;

		public global::ScheduleOne.PlayerTasks.DraggableConstraint DraggableConstraint;

		public global::ScheduleOne.Audio.AudioSourceController PourSound;

		[global::UnityEngine.Header("Particles")]
		public global::UnityEngine.Color PourParticlesColor;

		public float ParticleMinMultiplier;

		public float ParticleMaxMultiplier;

		private float[] particleMinSizes;

		private float[] particleMaxSizes;

		private global::ScheduleOne.StationFramework.Fillable activeFillable;

		private float timeSinceFillableHit;

		public bool IsPouring { get; protected set; }

		public float NormalizedPourRate { get; private set; }

		public float LiquidLevel { get; protected set; }

		public float NormalizedLiquidLevel => 0f;

		protected virtual void Start()
		{
		}

		public override void ActivateModule(global::ScheduleOne.StationFramework.StationItem item)
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void UpdatePouring()
		{
		}

		private void UpdatePourSound()
		{
		}

		public virtual void ChangeLiquidLevel(float change)
		{
		}

		public virtual void SetLiquidLevel(float level)
		{
		}

		protected virtual void PourAmount(float amount)
		{
		}

		private void ParticleCollision(global::UnityEngine.GameObject other)
		{
		}

		protected virtual bool CanPour()
		{
			return false;
		}
	}
}
