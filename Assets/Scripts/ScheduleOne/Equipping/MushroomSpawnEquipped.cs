namespace ScheduleOne.Equipping
{
	public class MushroomSpawnEquipped : global::ScheduleOne.Equipping.Equippable_Viewmodel
	{
		private const float InteractionRange = 2.5f;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.GameObject _taskPrefab;

		[global::UnityEngine.SerializeField]
		private string InteractionLabel { get; set; }

		protected override void Update()
		{
		}

		protected virtual bool CanApplyToMushroomBed(global::ScheduleOne.ObjectScripts.MushroomBed bed, out string reason)
		{
			reason = null;
			return false;
		}

		protected void StartTask(global::ScheduleOne.ObjectScripts.MushroomBed growContainer)
		{
		}
	}
}
