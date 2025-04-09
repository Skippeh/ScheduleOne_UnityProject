namespace ScheduleOne.Persistence.Datas
{
	public class DealerData : NPCData
	{
		public bool Recruited;

		public string[] AssignedCustomerIDs;

		public string[] ActiveContractGUIDs;

		public float Cash;

		public ItemSet OverflowItems;

		public bool HasBeenRecommended;

		public DealerData(string id, bool recruited, string[] assignedCustomerIDs, string[] activeContractGUIDs, float cash, ItemSet overflowItems, bool hasBeenRecommended)
			: base(null)
		{
		}
	}
}
