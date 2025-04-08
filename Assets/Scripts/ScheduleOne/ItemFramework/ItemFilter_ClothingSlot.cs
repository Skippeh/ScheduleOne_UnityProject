namespace ScheduleOne.ItemFramework
{
	public class ItemFilter_ClothingSlot : global::ScheduleOne.ItemFramework.ItemFilter
	{
		public global::ScheduleOne.Clothing.EClothingSlot SlotType { get; private set; }

		public ItemFilter_ClothingSlot(global::ScheduleOne.Clothing.EClothingSlot slot)
		{
		}

		public override bool DoesItemMatchFilter(global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
			return false;
		}
	}
}
