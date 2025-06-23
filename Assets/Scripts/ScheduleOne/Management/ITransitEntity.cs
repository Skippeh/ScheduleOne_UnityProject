namespace ScheduleOne.Management
{
	public interface ITransitEntity
	{
		public enum ESlotType
		{
			Input = 0,
			Output = 1,
			Both = 2
		}

		string Name { get; }

		global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> InputSlots { get; set; }

		global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> OutputSlots { get; set; }

		global::UnityEngine.Transform LinkOrigin { get; }

		global::UnityEngine.Transform[] AccessPoints { get; }

		bool Selectable { get; }

		bool IsAcceptingItems { get; }

		bool IsDestroyed { get; }

		global::System.Guid GUID { get; }

		void ShowOutline(global::UnityEngine.Color color);

		void HideOutline();

		void InsertItemIntoInput(global::ScheduleOne.ItemFramework.ItemInstance item, global::ScheduleOne.NPCs.NPC inserter = null)
		{
		}

		void InsertItemIntoOutput(global::ScheduleOne.ItemFramework.ItemInstance item, global::ScheduleOne.NPCs.NPC inserter = null)
		{
		}

		int GetInputCapacityForItem(global::ScheduleOne.ItemFramework.ItemInstance item, global::ScheduleOne.NPCs.NPC asker = null, bool checkPlayerFilters = true)
		{
			return 0;
		}

		int GetOutputCapacityForItem(global::ScheduleOne.ItemFramework.ItemInstance item, global::ScheduleOne.NPCs.NPC asker = null)
		{
			return 0;
		}

		global::ScheduleOne.ItemFramework.ItemSlot GetOutputItemContainer(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
			return null;
		}

		global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> ReserveInputSlotsForItem(global::ScheduleOne.ItemFramework.ItemInstance item, global::FishNet.Object.NetworkObject locker)
		{
			return null;
		}

		void RemoveSlotLocks(global::FishNet.Object.NetworkObject locker)
		{
		}

		global::ScheduleOne.ItemFramework.ItemSlot GetFirstSlotContainingItem(string id, global::ScheduleOne.Management.ITransitEntity.ESlotType searchType)
		{
			return null;
		}

		global::ScheduleOne.ItemFramework.ItemSlot GetFirstSlotContainingTemplateItem(global::ScheduleOne.ItemFramework.ItemInstance templateItem, global::ScheduleOne.Management.ITransitEntity.ESlotType searchType)
		{
			return null;
		}
	}
}
