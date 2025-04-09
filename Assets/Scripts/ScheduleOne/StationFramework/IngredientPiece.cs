using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	[RequireComponent(typeof(Draggable))]
	public class IngredientPiece : MonoBehaviour
	{
		public const float LIQUID_FRICTION = 100f;

		public LiquidContainer CurrentLiquidContainer;

		[Header("References")]
		public Transform ModelContainer;

		public ParticleSystem DissolveParticles;

		[Header("Settings")]
		public bool DetectLiquid;

		public bool DisableInteractionInLiquid;

		[Range(0f, 2f)]
		public float LiquidFrictionMultiplier;

		private Draggable draggable;

		private float defaultDrag;

		private Coroutine dissolveParticleRoutine;

		public float CurrentDissolveAmount { get; private set; }

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void UpdateDrag()
		{
		}

		private void CheckLiquid()
		{
		}

		public void DissolveAmount(float amount, bool showParticles = true)
		{
		}
	}
}
