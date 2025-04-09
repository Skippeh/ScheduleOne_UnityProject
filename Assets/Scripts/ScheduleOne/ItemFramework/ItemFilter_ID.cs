using System.Collections.Generic;

namespace ScheduleOne.ItemFramework
{
	public class ItemFilter_ID : ItemFilter
	{
		public bool IsWhitelist;

		public List<string> IDs;

		public ItemFilter_ID(List<string> ids)
		{
		}

		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return false;
		}
	}
}
