using System;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class BuildableItemData : SaveData
	{
		public string GUID;

		public string ItemString;

		public int LoadOrder;

		public BuildableItemData(Guid guid, ItemInstance item, int loadOrder)
		{
		}
	}
}
