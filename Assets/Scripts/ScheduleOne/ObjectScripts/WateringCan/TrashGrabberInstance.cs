namespace ScheduleOne.ObjectScripts.WateringCan
{
	[global::System.Serializable]
	public class TrashGrabberInstance : global::ScheduleOne.Storage.StorableItemInstance
	{
		public const int TRASH_CAPACITY = 20;

		private global::ScheduleOne.Trash.TrashContent Content;

		public TrashGrabberInstance(global::ScheduleOne.ItemFramework.ItemDefinition definition, int quantity)
			: base(null, 0)
		{
		}

		public override global::ScheduleOne.ItemFramework.ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		public void LoadContentData(global::ScheduleOne.Persistence.TrashContentData content)
		{
		}

		public override global::ScheduleOne.Persistence.Datas.ItemData GetItemData()
		{
			return null;
		}

		public void AddTrash(string id, int quantity)
		{
		}

		public void RemoveTrash(string id, int quantity)
		{
		}

		public void ClearTrash()
		{
		}

		public int GetTotalSize()
		{
			return 0;
		}

		public global::System.Collections.Generic.List<string> GetTrashIDs()
		{
			return null;
		}

		public global::System.Collections.Generic.List<int> GetTrashQuantities()
		{
			return null;
		}

		public global::System.Collections.Generic.List<ushort> GetTrashUshortQuantities()
		{
			return null;
		}

		public override void Write(global::FishNet.Serializing.Writer writer)
		{
		}

		public override void Read(global::FishNet.Serializing.Reader reader)
		{
		}
	}
}
