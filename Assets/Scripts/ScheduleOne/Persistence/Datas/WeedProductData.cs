namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class WeedProductData : global::ScheduleOne.Persistence.Datas.ProductData
	{
		public global::ScheduleOne.Product.WeedAppearanceSettings AppearanceSettings;

		public WeedProductData(string name, string id, global::ScheduleOne.Product.EDrugType drugType, string[] properties, global::ScheduleOne.Product.WeedAppearanceSettings appearanceSettings)
			: base(null, null, default(global::ScheduleOne.Product.EDrugType), null)
		{
		}
	}
}
