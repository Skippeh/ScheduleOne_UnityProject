namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class ShroomProductData : global::ScheduleOne.Persistence.Datas.ProductData
	{
		public global::ScheduleOne.Product.ShroomAppearanceSettings AppearanceSettings;

		public ShroomProductData(string name, string id, global::ScheduleOne.Product.EDrugType drugType, string[] properties, global::ScheduleOne.Product.ShroomAppearanceSettings appearanceSettings)
			: base(null, null, default(global::ScheduleOne.Product.EDrugType), null)
		{
		}
	}
}
