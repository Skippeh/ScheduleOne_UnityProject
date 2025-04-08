namespace ScheduleOne.ItemFramework
{
	public class ItemFilter_Dryable : global::ScheduleOne.ItemFramework.ItemFilter
	{
		public override bool DoesItemMatchFilter(global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
			return false;
		}

		public static bool IsItemDryable(global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
			return false;
		}
	}
}
