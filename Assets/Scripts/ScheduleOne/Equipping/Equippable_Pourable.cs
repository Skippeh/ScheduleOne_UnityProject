namespace ScheduleOne.Equipping
{
	public class Equippable_Pourable : global::ScheduleOne.Equipping.Equippable_Viewmodel
	{
		[global::UnityEngine.Header("Pourable settings")]
		public float InteractionRange;

		public global::ScheduleOne.PlayerTasks.Pourable PourablePrefab;

		public virtual string InteractionLabel { get; set; }

		protected override void Update()
		{
		}

		protected virtual void StartPourTask(global::ScheduleOne.ObjectScripts.Pot pot)
		{
		}

		protected virtual bool CanPour(global::ScheduleOne.ObjectScripts.Pot pot, out string reason)
		{
			reason = null;
			return false;
		}
	}
}
