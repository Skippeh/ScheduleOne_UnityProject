namespace ScheduleOne.Equipping
{
	public class Equippable_Pourable : global::ScheduleOne.Equipping.Equippable_Viewmodel
	{
		private const float InteractionRange = 2.5f;

		[global::UnityEngine.SerializeField]
		public global::ScheduleOne.PlayerTasks.Pourable PourablePrefab;

		[field: global::UnityEngine.SerializeField]
		public string InteractionLabel { get; set; }

		protected virtual void Awake()
		{
		}

		protected override void Update()
		{
		}

		protected virtual void StartPourTask(global::ScheduleOne.Growing.GrowContainer growContainer)
		{
		}

		protected virtual bool CanPour(global::ScheduleOne.Growing.GrowContainer growContainer, out string reason)
		{
			reason = null;
			return false;
		}
	}
}
