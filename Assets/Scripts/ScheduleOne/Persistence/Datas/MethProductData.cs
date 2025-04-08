namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class MethProductData : global::ScheduleOne.Persistence.Datas.ProductData
	{
		public global::ScheduleOne.Product.MethAppearanceSettings AppearanceSettings;

		public MethProductData(string name, string id, global::ScheduleOne.Product.EDrugType drugType, string[] properties, global::ScheduleOne.Product.MethAppearanceSettings appearanceSettings)
			: base(null, null, default(global::ScheduleOne.Product.EDrugType), null)
		{
		}
	}
}
