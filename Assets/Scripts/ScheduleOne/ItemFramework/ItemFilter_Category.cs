namespace ScheduleOne.ItemFramework
{
	public class ItemFilter_Category : global::ScheduleOne.ItemFramework.ItemFilter
	{
		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.EItemCategory> AcceptedCategories;

		public ItemFilter_Category(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.EItemCategory> acceptedCategories)
		{
		}

		public override bool DoesItemMatchFilter(global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
			return false;
		}
	}
}
