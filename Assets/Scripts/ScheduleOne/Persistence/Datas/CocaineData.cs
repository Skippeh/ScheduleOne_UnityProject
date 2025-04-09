using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class CocaineData : ProductItemData
	{
		public CocaineData(string iD, int quantity, string quality, string packagingID)
			: base(null, 0, null, null)
		{
		}
	}
}
