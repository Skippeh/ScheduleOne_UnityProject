namespace ScheduleOne.ItemFramework
{
	public class ItemFilter_UnpackagedProduct : global::ScheduleOne.ItemFramework.ItemFilter_Category
	{
		public ItemFilter_UnpackagedProduct()
			: base(null)
		{
		}

		public override bool DoesItemMatchFilter(global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
			return false;
		}
	}
}
