namespace ScheduleOne.ItemFramework
{
	public class ItemFilter_Category : global::ScheduleOne.ItemFramework.ItemFilter
	{
		public global::System.Collections.Generic.List<global::ScheduleOne.Core.Items.Framework.EItemCategory> AcceptedCategories;

		public ItemFilter_Category(global::System.Collections.Generic.List<global::ScheduleOne.Core.Items.Framework.EItemCategory> acceptedCategories)
		{
		}

		public override bool DoesItemMatchFilter(global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
			return false;
		}
	}
}
