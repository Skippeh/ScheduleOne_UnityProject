using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Trash
{
	public class TrashBag : TrashItem
	{
		public TrashContent Content { get; private set; }

		public void LoadContent(TrashContentData data)
		{
		}

		public override TrashItemData GetData()
		{
			return null;
		}
	}
}
