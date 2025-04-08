namespace ScheduleOne.ItemFramework
{
	public class ItemFilter_PackagedProduct : global::ScheduleOne.ItemFramework.ItemFilter_Category
	{
		public ItemFilter_PackagedProduct()
			: base(null)
		{
		}

		public override bool DoesItemMatchFilter(global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
			return false;
		}
	}
}
