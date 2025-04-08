namespace ScheduleOne.PlayerTasks
{
	public class ApplyAdditiveToPot : global::ScheduleOne.PlayerTasks.Tasks.PourIntoPotTask
	{
		private global::ScheduleOne.ItemFramework.AdditiveDefinition def;

		protected override bool UseCoverage => false;

		protected override global::ScheduleOne.ObjectScripts.Pot.ECameraPosition CameraPosition => default(global::ScheduleOne.ObjectScripts.Pot.ECameraPosition);

		public ApplyAdditiveToPot(global::ScheduleOne.ObjectScripts.Pot _pot, global::ScheduleOne.ItemFramework.ItemInstance _itemInstance, global::ScheduleOne.PlayerTasks.Pourable _pourablePrefab)
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
