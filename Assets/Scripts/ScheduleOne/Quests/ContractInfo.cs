namespace ScheduleOne.Quests
{
	[global::System.Serializable]
	public class ContractInfo
	{
		public float Payment;

		public global::ScheduleOne.Product.ProductList Products;

		public string DeliveryLocationGUID;

		public global::ScheduleOne.Quests.QuestWindowConfig DeliveryWindow;

		public bool Expires;

		public int ExpiresAfter;

		public int PickupScheduleIndex;

		public bool IsCounterOffer;

		public global::ScheduleOne.Economy.DeliveryLocation DeliveryLocation { get; private set; }

		public ContractInfo(float payment, global::ScheduleOne.Product.ProductList products, string deliveryLocationGUID, global::ScheduleOne.Quests.QuestWindowConfig deliveryWindow, bool expires, int expiresAfter, int pickupScheduleIndex, bool isCounterOffer)
		{
		}

		public ContractInfo()
		{
		}

		public global::ScheduleOne.Dialogue.DialogueChain ProcessMessage(global::ScheduleOne.Dialogue.DialogueChain messageChain)
		{
			return null;
		}
	}
}
