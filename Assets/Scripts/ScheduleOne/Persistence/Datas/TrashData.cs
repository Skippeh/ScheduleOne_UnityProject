using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class TrashData : SaveData
	{
		public TrashItemData[] Items;

		public TrashData(TrashItemData[] trash)
		{
		}
	}
}
