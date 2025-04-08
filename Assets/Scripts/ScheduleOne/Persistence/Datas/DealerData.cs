namespace ScheduleOne.Persistence.Datas
{
	public class DealerData : global::ScheduleOne.Persistence.Datas.NPCData
	{
		public bool Recruited;

		public string[] AssignedCustomerIDs;

		public string[] ActiveContractGUIDs;

		public float Cash;

		public global::ScheduleOne.Persistence.Datas.ItemSet OverflowItems;

		public bool HasBeenRecommended;

		public DealerData(string id, bool recruited, string[] assignedCustomerIDs, string[] activeContractGUIDs, float cash, global::ScheduleOne.Persistence.Datas.ItemSet overflowItems, bool hasBeenRecommended)
			: base(null)
		{
		}
	}
}
