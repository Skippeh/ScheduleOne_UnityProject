namespace ScheduleOne.Trash
{
	[global::System.Serializable]
	public class TrashContent
	{
		[global::System.Serializable]
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

		public global::System.Collections.Generic.List<global::ScheduleOne.Trash.TrashContent.Entry> Entries;

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

		public global::ScheduleOne.Persistence.TrashContentData GetData()
		{
			return null;
		}

		public void LoadFromData(global::ScheduleOne.Persistence.TrashContentData data)
		{
		}
	}
}
