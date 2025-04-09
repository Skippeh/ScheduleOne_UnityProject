using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Equipping
{
	public class Equippable_Additive : Equippable_Pourable
	{
		private AdditiveDefinition additiveDef;

		public override void Equip(ItemInstance item)
		{
		}

		protected override void StartPourTask(Pot pot)
		{
		}

		protected override bool CanPour(Pot pot, out string reason)
		{
			reason = null;
			return false;
		}
	}
}
