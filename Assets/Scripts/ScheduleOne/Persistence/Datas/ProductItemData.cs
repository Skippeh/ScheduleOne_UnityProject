namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class ProductItemData : global::ScheduleOne.Persistence.Datas.QualityItemData
	{
		public string PackagingID;

		public ProductItemData(string iD, int quantity, string quality, string packagingID)
			: base(null, 0, null)
		{
		}
	}
}
