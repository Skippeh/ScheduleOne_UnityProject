using System.Collections.Generic;

namespace ScheduleOne.ItemFramework
{
	public class IDs : ItemFilter
	{
		public List<string> AcceptedIDs;

		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return false;
		}
	}
}
