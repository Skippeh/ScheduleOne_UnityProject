namespace ScheduleOne.ObjectScripts.Soil
{
	public class Equippable_Soil : global::ScheduleOne.Equipping.Equippable_Pourable
	{
		public override string InteractionLabel { get; set; }

		protected override bool CanPour(global::ScheduleOne.ObjectScripts.Pot pot, out string reason)
		{
			reason = null;
			return false;
		}

		protected override void StartPourTask(global::ScheduleOne.ObjectScripts.Pot pot)
		{
		}
	}
}
