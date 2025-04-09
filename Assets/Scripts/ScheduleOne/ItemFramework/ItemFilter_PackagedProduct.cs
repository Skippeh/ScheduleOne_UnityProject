namespace ScheduleOne.ItemFramework
{
	public class ItemFilter_PackagedProduct : ItemFilter_Category
	{
		public ItemFilter_PackagedProduct()
			: base(null)
		{
		}

		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return false;
		}
	}
}
