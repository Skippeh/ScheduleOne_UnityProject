using System;
using System.Collections.Generic;
using ScheduleOne.Persistence;

namespace ScheduleOne.Trash
{
	[Serializable]
	public class TrashContent
	{
		[Serializable]
		public class Entry
		{
			public string TrashID;

			public int Quantity;

			public int UnitSize { get; private set; }

			public int UnitValue { get; private set; }

			public Entry(string id, int quantity)
			{
			}
		}

		public List<Entry> Entries;

		public void AddTrash(string trashID, int quantity)
		{
		}

		public void RemoveTrash(string trashID, int quantity)
		{
		}

		public int GetTrashQuantity(string trashID)
		{
			return 0;
		}

		public void Clear()
		{
		}

		public int GetTotalSize()
		{
			return 0;
		}

		public TrashContentData GetData()
		{
			return null;
		}

		public void LoadFromData(TrashContentData data)
		{
		}
	}
}
