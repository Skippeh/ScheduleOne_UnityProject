using System;
using ScheduleOne.Product;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class MethProductData : ProductData
	{
		public MethAppearanceSettings AppearanceSettings;

		public MethProductData(string name, string id, EDrugType drugType, string[] properties, MethAppearanceSettings appearanceSettings)
			: base(null, null, default(EDrugType), null)
		{
		}
	}
}
