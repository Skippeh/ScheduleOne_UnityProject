namespace ScheduleOne.Equipping
{
	public class Equippable : global::UnityEngine.MonoBehaviour
	{
		protected global::ScheduleOne.ItemFramework.ItemInstance itemInstance;

		public bool CanInteractWhenEquipped;

		public bool CanPickUpWhenEquipped;

		public virtual void Equip(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		public virtual void Unequip()
		{
		}

		protected virtual void Update()
		{
		}
	}
}
