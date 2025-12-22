namespace ScheduleOne.Equipping
{
	public class Equippable_Additive : global::ScheduleOne.Equipping.Equippable_Pourable
	{
		private global::ScheduleOne.ItemFramework.AdditiveDefinition additiveDef;

		public override void Equip(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		protected override void StartPourTask(global::ScheduleOne.Growing.GrowContainer growContainer)
		{
		}

		protected override bool CanPour(global::ScheduleOne.Growing.GrowContainer pot, out string reason)
		{
			reason = null;
			return false;
		}
	}
}
