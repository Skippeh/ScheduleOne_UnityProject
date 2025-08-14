namespace ScheduleOne.Economy
{
	[global::System.Serializable]
	public class ContractReceipt
	{
		public int ReceiptId;

		public global::ScheduleOne.Economy.EContractParty CompletedBy;

		public string CustomerId;

		public global::ScheduleOne.GameTime.GameDateTime CompletionTime;

		public global::ScheduleOne.DevUtilities.StringIntPair[] Items;

		public float AmountPaid;

		public ContractReceipt(int receiptId, global::ScheduleOne.Economy.EContractParty completedBy, string customerID, global::ScheduleOne.GameTime.GameDateTime completionTime, global::ScheduleOne.DevUtilities.StringIntPair[] items, float amountPaid)
		{
		}

		public ContractReceipt()
		{
		}
	}
}
