using System.Collections.Generic;

namespace ScheduleOne.ItemFramework
{
	public class ItemFilter_Category : ItemFilter
	{
		public List<EItemCategory> AcceptedCategories;

		public ItemFilter_Category(List<EItemCategory> acceptedCategories)
		{
		}

		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return false;
		}
	}
}
