using System;
using System.Collections.Generic;
using FishNet.Object;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using UnityEngine;

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

		List<ItemSlot> InputSlots { get; set; }

		List<ItemSlot> OutputSlots { get; set; }

		Transform LinkOrigin { get; }

		Transform[] AccessPoints { get; }

		bool Selectable { get; }

		bool IsAcceptingItems { get; }

		bool IsDestroyed { get; }

		Guid GUID { get; }

		void ShowOutline(Color color);

		void HideOutline();

		void InsertItemIntoInput(ItemInstance item, NPC inserter = null)
		{
		}

		void InsertItemIntoOutput(ItemInstance item, NPC inserter = null)
		{
		}

		int GetInputCapacityForItem(ItemInstance item, NPC asker = null)
		{
			return 0;
		}

		int GetOutputCapacityForItem(ItemInstance item, NPC asker = null)
		{
			return 0;
		}

		ItemSlot GetOutputItemContainer(ItemInstance item)
		{
			return null;
		}

		List<ItemSlot> ReserveInputSlotsForItem(ItemInstance item, NetworkObject locker)
		{
			return null;
		}

		void RemoveSlotLocks(NetworkObject locker)
		{
		}

		ItemSlot GetFirstSlotContainingItem(string id, ESlotType searchType)
		{
			return null;
		}

		ItemSlot GetFirstSlotContainingTemplateItem(ItemInstance templateItem, ESlotType searchType)
		{
			return null;
		}
	}
}
