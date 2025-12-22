namespace ScheduleOne.PlayerTasks
{
	public class ApplyAdditiveToPot : global::ScheduleOne.PlayerTasks.Tasks.GrowContainerPourTask
	{
		private global::ScheduleOne.ItemFramework.AdditiveDefinition def;

		protected override bool UseCoverage => false;

		protected override global::ScheduleOne.Growing.GrowContainerCameraHandler.ECameraPosition CameraPosition => default(global::ScheduleOne.Growing.GrowContainerCameraHandler.ECameraPosition);

		public ApplyAdditiveToPot(global::ScheduleOne.Growing.GrowContainer _growContainer, global::ScheduleOne.ItemFramework.ItemInstance _itemInstance, global::ScheduleOne.PlayerTasks.Pourable _pourablePrefab)
			: base(null, null, null)
		{
		}

		public override void Update()
		{
		}

		protected override void FullyCovered()
		{
		}
	}
}
