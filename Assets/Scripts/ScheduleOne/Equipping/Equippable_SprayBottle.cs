namespace ScheduleOne.Equipping
{
	public class Equippable_SprayBottle : global::ScheduleOne.Equipping.Equippable_Viewmodel
	{
		private const float InteractionRange = 2.5f;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.GameObject _sprayablePrefab;

		private global::ScheduleOne.ItemFramework.WaterContainerInstance _waterContainerInstance;

		[global::UnityEngine.SerializeField]
		private string InteractionLabel { get; set; }

		protected override void Update()
		{
		}

		protected virtual bool CanSpray(global::ScheduleOne.Growing.GrowContainer growContainer, out string reason)
		{
			reason = null;
			return false;
		}

		protected void StartSprayTask(global::ScheduleOne.ObjectScripts.MushroomBed growContainer)
		{
		}
	}
}
