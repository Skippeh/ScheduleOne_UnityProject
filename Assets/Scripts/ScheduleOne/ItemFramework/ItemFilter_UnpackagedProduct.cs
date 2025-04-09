namespace ScheduleOne.ItemFramework
{
	public class ItemFilter_UnpackagedProduct : ItemFilter_Category
	{
		public ItemFilter_UnpackagedProduct()
			: base(null)
		{
		}

		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return false;
		}
	}
}
