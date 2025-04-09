using ScheduleOne.Audio;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	public class PourableModule : ItemModule
	{
		[Header("Settings")]
		public string LiquidType;

		public float PourRate;

		public float AngleFromUpToPour;

		public bool OnlyEmptyOverFillable;

		public float LiquidCapacity_L;

		public Color LiquidColor;

		public float DefaultLiquid_L;

		[Header("References")]
		public ParticleSystem[] PourParticles;

		public Transform PourPoint;

		public LiquidContainer LiquidContainer;

		public Draggable Draggable;

		public DraggableConstraint DraggableConstraint;

		public AudioSourceController PourSound;

		[Header("Particles")]
		public Color PourParticlesColor;

		public float ParticleMinMultiplier;

		public float ParticleMaxMultiplier;

		private float[] particleMinSizes;

		private float[] particleMaxSizes;

		private Fillable activeFillable;

		private float timeSinceFillableHit;

		public bool IsPouring { get; protected set; }

		public float NormalizedPourRate { get; private set; }

		public float LiquidLevel { get; protected set; }

		public float NormalizedLiquidLevel => 0f;

		protected virtual void Start()
		{
		}

		public override void ActivateModule(StationItem item)
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

		private void ParticleCollision(GameObject other)
		{
		}

		protected virtual bool CanPour()
		{
			return false;
		}
	}
}
