namespace ScheduleOne.Economy
{
	[global::System.Serializable]
	public class DealGenerationEvent
	{
		[global::System.Serializable]
		public class DayContainer
		{
			public global::ScheduleOne.GameTime.EDay Day;
		}

		[global::UnityEngine.Header("Settings")]
		public bool Enabled;

		public bool CanBeAccepted;

		public bool CanBeRejected;

		[global::UnityEngine.Header("Timing Settings")]
		public global::System.Collections.Generic.List<global::ScheduleOne.Economy.DealGenerationEvent.DayContainer> ApplicableDays;

		public int GenerationTime;

		public int GenerationWindowDuration;

		[global::UnityEngine.Header("Products and payment")]
		public global::ScheduleOne.Product.ProductList ProductList;

		public float Payment;

		[global::UnityEngine.Range(0f, 5f)]
		public float RelationshipRequirement;

		[global::UnityEngine.Header("Messages")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UI.Phone.Messages.MessageChain[] RequestMessageChains;

		public global::ScheduleOne.UI.Phone.Messages.MessageChain[] ContractAcceptedResponses;

		public global::ScheduleOne.UI.Phone.Messages.MessageChain[] ContractRejectedResponses;

		[global::UnityEngine.Header("Location settings")]
		public global::ScheduleOne.Economy.DeliveryLocation DeliveryLocation;

		public int PickupScheduleGroup;

		[global::UnityEngine.Header("Window/expiry settings")]
		public global::ScheduleOne.Quests.QuestWindowConfig DeliveryWindow;

		public bool Expires;

		[global::UnityEngine.Tooltip("How many days after being accepted does this contract expire? Exact expiry is adjusted to match window end")]
		[global::UnityEngine.Range(1f, 7f)]
		public int ExpiresAfter;

		public global::ScheduleOne.Quests.ContractInfo GenerateContractInfo(global::ScheduleOne.Economy.Customer customer)
		{
			return null;
		}

		public bool ShouldGenerate(global::ScheduleOne.Economy.Customer customer)
		{
			return false;
		}

		public global::ScheduleOne.UI.Phone.Messages.MessageChain GetRandomRequestMessage()
		{
			return null;
		}

		public global::ScheduleOne.UI.Phone.Messages.MessageChain ProcessMessage(global::ScheduleOne.UI.Phone.Messages.MessageChain messageChain)
		{
			return null;
		}

		public global::ScheduleOne.UI.Phone.Messages.MessageChain GetRejectionMessage()
		{
			return null;
		}

		public global::ScheduleOne.UI.Phone.Messages.MessageChain GetAcceptanceMessage()
		{
			return null;
		}

		public string GetProductStringList()
		{
			return null;
		}

		public string GetQualityString()
		{
			return null;
		}
	}
}
