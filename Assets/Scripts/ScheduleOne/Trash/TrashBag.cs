namespace ScheduleOne.Trash
{
	public class TrashBag : global::ScheduleOne.Trash.TrashItem
	{
		public global::ScheduleOne.Trash.TrashContent Content { get; private set; }

		public void LoadContent(global::ScheduleOne.Persistence.TrashContentData data)
		{
		}

		public override global::ScheduleOne.Persistence.Datas.TrashItemData GetData()
		{
			return null;
		}
	}
}
