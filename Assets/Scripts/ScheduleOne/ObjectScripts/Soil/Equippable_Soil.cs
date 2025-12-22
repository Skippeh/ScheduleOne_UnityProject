namespace ScheduleOne.ObjectScripts.Soil
{
	public class Equippable_Soil : global::ScheduleOne.Equipping.Equippable_Pourable
	{
		protected override bool CanPour(global::ScheduleOne.Growing.GrowContainer growContainer, out string reason)
		{
			reason = null;
			return false;
		}

		protected override void StartPourTask(global::ScheduleOne.Growing.GrowContainer growContainer)
		{
		}
	}
}
