namespace ScheduleOne.Persistence
{
	[global::System.Serializable]
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

		public TrashContentData(global::System.Collections.Generic.List<global::ScheduleOne.Trash.TrashItem> trashItems)
		{
		}
	}
}
