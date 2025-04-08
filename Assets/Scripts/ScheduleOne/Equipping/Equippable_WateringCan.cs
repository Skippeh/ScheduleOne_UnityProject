namespace ScheduleOne.Equipping
{
	public class Equippable_WateringCan : global::ScheduleOne.Equipping.Equippable_Pourable
	{
		public global::ScheduleOne.ObjectScripts.WateringCan.WateringCanVisuals Visuals;

		private global::ScheduleOne.ObjectScripts.WateringCan.WateringCanInstance WCInstance;

		public override string InteractionLabel { get; set; }

		public override void Equip(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		public override void Unequip()
		{
		}

		private void UpdateVisuals()
		{
		}

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
