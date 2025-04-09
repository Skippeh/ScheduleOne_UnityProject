namespace ScheduleOne.ItemFramework
{
	public class ItemFilter_Dryable : ItemFilter
	{
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return false;
		}

		public static bool IsItemDryable(ItemInstance instance)
		{
			return false;
		}
	}
}
