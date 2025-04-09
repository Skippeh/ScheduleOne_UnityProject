using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.ObjectScripts.WateringCan;

namespace ScheduleOne.Equipping
{
	public class Equippable_WateringCan : Equippable_Pourable
	{
		public WateringCanVisuals Visuals;

		private WateringCanInstance WCInstance;

		public override string InteractionLabel { get; set; }

		public override void Equip(ItemInstance item)
		{
		}

		public override void Unequip()
		{
		}

		private void UpdateVisuals()
		{
		}

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
