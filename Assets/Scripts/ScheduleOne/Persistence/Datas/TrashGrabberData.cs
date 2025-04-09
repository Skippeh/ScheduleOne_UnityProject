using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class TrashGrabberData : ItemData
	{
		public TrashContentData Content;

		public TrashGrabberData(string iD, int quantity, TrashContentData content)
			: base(null, 0)
		{
		}
	}
}
