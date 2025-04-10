namespace ScheduleOne.ItemFramework
{
	public class ItemFilter_ID : global::ScheduleOne.ItemFramework.ItemFilter
	{
		public bool IsWhitelist;

		public global::System.Collections.Generic.List<string> IDs;

		public ItemFilter_ID(global::System.Collections.Generic.List<string> ids)
		{
		}

		public override bool DoesItemMatchFilter(global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
			return false;
		}
	}
}
