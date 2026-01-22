namespace ScheduleOne.Quests
{
	public class Contract : global::ScheduleOne.Quests.Quest
	{
		public class BonusPayment
		{
			public string Title;

			public float Amount;

			public BonusPayment(string title, float amount)
			{
			}
		}

		public const int DefaultExpiryTime = 2880;

		public const float ExcessProductsMatchSumMultiplier = 0.5f;

		public static global::System.Collections.Generic.List<global::ScheduleOne.Quests.Contract> Contracts;

		[global::UnityEngine.Header("Contract Settings")]
		public global::ScheduleOne.Product.ProductList ProductList;

		public global::ScheduleOne.Economy.DeliveryLocation DeliveryLocation;

		public global::ScheduleOne.Quests.QuestWindowConfig DeliveryWindow;

		private bool completedContractsIncremented;

		public global::FishNet.Object.NetworkObject Customer { get; protected set; }

		public global::ScheduleOne.Economy.Dealer Dealer { get; protected set; }

		public float Payment { get; protected set; }

		public int PickupScheduleIndex { get; protected set; }

		public global::ScheduleOne.GameTime.GameDateTime AcceptTime { get; protected set; }

		protected override void Start()
		{
		}

		public virtual void InitializeContract(string title, string description, global::ScheduleOne.Persistence.Datas.QuestEntryData[] entries, string guid, global::ScheduleOne.Economy.Customer customer, float payment, global::ScheduleOne.Product.ProductList products, string deliveryLocationGUID, global::ScheduleOne.Quests.QuestWindowConfig deliveryWindow, int pickupScheduleIndex, global::ScheduleOne.GameTime.GameDateTime acceptTime)
		{
		}

		public virtual void SilentlyInitializeContract(string title, string description, global::ScheduleOne.Persistence.Datas.QuestEntryData[] entries, string guid, global::ScheduleOne.Economy.Customer customer, float payment, global::ScheduleOne.Product.ProductList products, string deliveryLocationGUID, global::ScheduleOne.Quests.QuestWindowConfig deliveryWindow, int pickupScheduleIndex, global::ScheduleOne.GameTime.GameDateTime acceptTime)
		{
		}

		protected override void OnUncappedMinPass()
		{
		}

		private void OnDestroy()
		{
		}

		private void UpdateTiming()
		{
		}

		public void UpdatePoI()
		{
		}

		public override void End()
		{
		}

		public override void Complete(bool network = true)
		{
		}

		public override void Expire(bool network = true)
		{
		}

		public override void Fail(bool network = true)
		{
		}

		public void SetDealer(global::ScheduleOne.Economy.Dealer dealer)
		{
		}

		public virtual void SubmitPayment(float bonusTotal)
		{
		}

		protected override void SendExpiryReminder()
		{
		}

		protected override void SendExpiredNotification()
		{
		}

		protected override bool ShouldShowJournalEntry()
		{
			return false;
		}

		protected override bool CanExpire()
		{
			return false;
		}

		public bool DoesProductListMatchSpecified(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> items, bool enforceQuality)
		{
			return false;
		}

		public float GetProductListMatch(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> items, out int matchedProductCount)
		{
			matchedProductCount = default(int);
			return 0f;
		}

		private global::System.Collections.Generic.Dictionary<global::ScheduleOne.Product.ProductItemInstance, float> GetDescendingMatchRatings(global::ScheduleOne.Product.ProductList.Entry requestedItem, global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> providedItems)
		{
			return null;
		}

		public override global::ScheduleOne.Persistence.Datas.SaveData GetSaveData()
		{
			return null;
		}

		public new bool ShouldSave()
		{
			return false;
		}
	}
}
