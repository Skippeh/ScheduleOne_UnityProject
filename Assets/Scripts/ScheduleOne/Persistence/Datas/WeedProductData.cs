using System;
using ScheduleOne.Product;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class WeedProductData : ProductData
	{
		public WeedAppearanceSettings AppearanceSettings;

		public WeedProductData(string name, string id, EDrugType drugType, string[] properties, WeedAppearanceSettings appearanceSettings)
			: base(null, null, default(EDrugType), null)
		{
		}
	}
}
