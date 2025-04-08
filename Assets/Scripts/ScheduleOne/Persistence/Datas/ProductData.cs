namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class ProductData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public string Name;

		public string ID;

		public global::ScheduleOne.Product.EDrugType DrugType;

		public string[] Properties;

		public ProductData(string name, string id, global::ScheduleOne.Product.EDrugType drugType, string[] properties)
		{
		}
	}
}
