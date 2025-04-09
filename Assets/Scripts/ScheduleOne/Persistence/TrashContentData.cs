using System;
using System.Collections.Generic;
using ScheduleOne.Trash;

namespace ScheduleOne.Persistence
{
	[Serializable]
	public class TrashContentData
	{
		public string[] TrashIDs;

		public int[] TrashQuantities;

		public TrashContentData()
		{
		}

		public TrashContentData(string[] trashIDs, int[] trashQuantities)
		{
		}

		public TrashContentData(List<TrashItem> trashItems)
		{
		}
	}
}
