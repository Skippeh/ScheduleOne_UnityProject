namespace ScheduleOne.PlayerScripts
{
	public class HotbarSlot : global::ScheduleOne.ItemFramework.ItemSlot
	{
		public delegate void EquipEvent(bool equipped);

		public global::ScheduleOne.Equipping.Equippable Equippable;

		public global::ScheduleOne.PlayerScripts.HotbarSlot.EquipEvent onEquipChanged;

		public bool IsEquipped { get; protected set; }

		public override void SetStoredItem(global::ScheduleOne.ItemFramework.ItemInstance instance, bool _internal = false)
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
