using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.PlayerScripts
{
	public class HotbarSlot : ItemSlot
	{
		public delegate void EquipEvent(bool equipped);

		public Equippable Equippable;

		public EquipEvent onEquipChanged;

		public bool IsEquipped { get; protected set; }

		public override void SetStoredItem(ItemInstance instance, bool _internal = false)
		{
		}

		public override void ClearStoredInstance(bool _internal = false)
		{
		}

		public virtual void Equip()
		{
		}

		public virtual void Unequip()
		{
		}

		public override bool CanSlotAcceptCash()
		{
			return false;
		}
	}
}
