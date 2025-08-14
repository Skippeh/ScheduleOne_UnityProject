namespace ScheduleOne.Tools
{
	public class BombPlantLocation : global::UnityEngine.MonoBehaviour
	{
		public const float COUNTDOWN_TIME = 45f;

		public const float BEEP_INTERVAL_MAX = 1f;

		public const float BEEP_INTERVAL_MIN = 0.125f;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.GameObject BombModel;

		public global::UnityEngine.Events.UnityEvent onPlantBomb;

		public global::UnityEngine.Events.UnityEvent onBeep;

		public global::UnityEngine.Events.UnityEvent onDetonate;

		public bool BombPlanted { get; private set; }

		private void Awake()
		{
		}

		private void Hovered()
		{
		}

		private void Interacted()
		{
		}

		public void PlantBomb()
		{
		}

		private bool CanPlantBomb()
		{
			return false;
		}
	}
}
