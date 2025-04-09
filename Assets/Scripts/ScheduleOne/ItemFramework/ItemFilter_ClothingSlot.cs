using ScheduleOne.Clothing;

namespace ScheduleOne.ItemFramework
{
	public class ItemFilter_ClothingSlot : ItemFilter
	{
		public EClothingSlot SlotType { get; private set; }

		public ItemFilter_ClothingSlot(EClothingSlot slot)
		{
		}

		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return false;
		}
	}
}
