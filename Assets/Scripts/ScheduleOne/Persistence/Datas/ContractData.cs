namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class ContractData : global::ScheduleOne.Persistence.Datas.QuestData
	{
		public string CustomerGUID;

		public float Payment;

		public global::ScheduleOne.Product.ProductList ProductList;

		public string DeliveryLocationGUID;

		public global::ScheduleOne.Quests.QuestWindowConfig DeliveryWindow;

		public int PickupScheduleIndex;

		public global::ScheduleOne.Persistence.Datas.GameDateTimeData AcceptTime;

		public ContractData(string guid, global::ScheduleOne.Quests.EQuestState state, bool isTracked, string title, string desc, bool isTimed, global::ScheduleOne.Persistence.Datas.GameDateTimeData expiry, global::ScheduleOne.Persistence.Datas.QuestEntryData[] entries, string customerGUID, float payment, global::ScheduleOne.Product.ProductList productList, string deliveryLocationGUID, global::ScheduleOne.Quests.QuestWindowConfig deliveryWindow, int pickupScheduleIndex, global::ScheduleOne.Persistence.Datas.GameDateTimeData acceptTime)
			: base(null, default(global::ScheduleOne.Quests.EQuestState), isTracked: false, null, null, expires: false, null, null)
		{
		}
	}
}
