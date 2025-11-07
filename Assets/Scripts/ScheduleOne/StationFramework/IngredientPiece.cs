namespace ScheduleOne.StationFramework
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.PlayerTasks.Draggable))]
	public class IngredientPiece : global::UnityEngine.MonoBehaviour
	{
		public const float LIQUID_FRICTION = 100f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform ModelContainer;

		public global::UnityEngine.ParticleSystem DissolveParticles;

		[global::UnityEngine.Header("Settings")]
		public bool DetectLiquid;

		public bool DisableInteractionInLiquid;

		[global::UnityEngine.Range(0f, 2f)]
		public float LiquidFrictionMultiplier;

		private global::ScheduleOne.PlayerTasks.Draggable draggable;

		private float defaultDrag;

		private global::UnityEngine.Coroutine dissolveParticleRoutine;

		public float CurrentDissolveAmount { get; private set; }

		public global::ScheduleOne.StationFramework.LiquidContainer CurrentLiquidContainer { get; private set; }

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
