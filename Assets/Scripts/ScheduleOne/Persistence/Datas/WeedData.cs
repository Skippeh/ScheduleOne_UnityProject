using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class WeedData : ProductItemData
	{
		public WeedData(string iD, int quantity, string quality, string packagingID)
			: base(null, 0, null, null)
		{
		}
	}
}
