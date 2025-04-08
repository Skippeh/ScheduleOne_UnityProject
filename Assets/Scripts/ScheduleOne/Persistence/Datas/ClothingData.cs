namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class ClothingData : global::ScheduleOne.Persistence.Datas.ItemData
	{
		public global::ScheduleOne.Clothing.EClothingColor Color;

		public ClothingData(string iD, int quantity, global::ScheduleOne.Clothing.EClothingColor color)
			: base(null, 0)
		{
		}
	}
}
