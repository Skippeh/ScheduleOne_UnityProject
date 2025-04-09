using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class QualityItemData : ItemData
	{
		public string Quality;

		public QualityItemData(string iD, int quantity, string quality)
			: base(null, 0)
		{
		}
	}
}
