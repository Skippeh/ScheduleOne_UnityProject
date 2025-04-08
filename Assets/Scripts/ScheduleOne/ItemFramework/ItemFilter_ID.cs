namespace ScheduleOne.ItemFramework
{
	public class ItemFilter_ID : global::ScheduleOne.ItemFramework.ItemFilter
	{
		public global::System.Collections.Generic.List<string> AcceptedIDs;

		public ItemFilter_ID(global::System.Collections.Generic.List<string> acceptedIDs)
		{
		}

		public override bool DoesItemMatchFilter(global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
			return false;
		}
	}
}
