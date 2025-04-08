namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class CocaineProductData : global::ScheduleOne.Persistence.Datas.ProductData
	{
		public global::ScheduleOne.Product.CocaineAppearanceSettings AppearanceSettings;

		public CocaineProductData(string name, string id, global::ScheduleOne.Product.EDrugType drugType, string[] properties, global::ScheduleOne.Product.CocaineAppearanceSettings appearanceSettings)
			: base(null, null, default(global::ScheduleOne.Product.EDrugType), null)
		{
		}
	}
}
