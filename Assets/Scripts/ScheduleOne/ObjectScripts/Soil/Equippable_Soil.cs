using ScheduleOne.Equipping;

namespace ScheduleOne.ObjectScripts.Soil
{
	public class Equippable_Soil : Equippable_Pourable
	{
		public override string InteractionLabel { get; set; }

		protected override bool CanPour(Pot pot, out string reason)
		{
			reason = null;
			return false;
		}

		protected override void StartPourTask(Pot pot)
		{
		}
	}
}
