namespace ScheduleOne.PlayerScripts
{
	public class HotbarSlot : global::ScheduleOne.ItemFramework.ItemSlot
	{
		public delegate void EquipEvent(bool equipped);

		public global::ScheduleOne.PlayerScripts.HotbarSlot.EquipEvent onEquipChanged;

		private global::ScheduleOne.Equipping.Equippable _equippable;

		private global::ScheduleOne.Core.Equipping.Framework.IEquippedItemHandler _equippedItem;

		public bool IsSelected { get; protected set; }

		public override void SetStoredItem(global::ScheduleOne.ItemFramework.ItemInstance instance, bool _internal = false)
		{
		}

		public override void ClearStoredInstance(bool _internal = false)
		{
		}

		public virtual void Select()
		{
		}

		private void Equip()
		{
		}

		private void Unequip()
		{
		}

		public virtual void Deselect()
		{
		}

		public override bool CanSlotAcceptCash()
		{
			return false;
		}
	}
}
