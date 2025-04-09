using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	public class TrashBagData : TrashItemData
	{
		public TrashBagData(string trashID, string guid, Vector3 position, Quaternion rotation, TrashContentData contents)
			: base(null, null, default(Vector3), default(Quaternion))
		{
		}
	}
}
