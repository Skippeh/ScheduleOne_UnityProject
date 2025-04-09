using System.Collections.Generic;
using FishNet.Object;
using ScheduleOne.Economy;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Quests
{
	public class Contract : Quest
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

		public static List<Contract> Contracts;

		[Header("Contract Settings")]
		public ProductList ProductList;

		public DeliveryLocation DeliveryLocation;

		public QuestWindowConfig DeliveryWindow;

		private bool completedContractsIncremented;

		public NetworkObject Customer { get; protected set; }

		public Dealer Dealer { get; protected set; }

		public float Payment { get; protected set; }

		public int PickupScheduleIndex { get; protected set; }

		public GameDateTime AcceptTime { get; protected set; }

		protected override void Start()
		{
		}

		public virtual void InitializeContract(string title, string description, QuestEntryData[] entries, string guid, NetworkObject customer, float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, int pickupScheduleIndex, GameDateTime acceptTime)
		{
		}

		public virtual void SilentlyInitializeContract(string title, string description, QuestEntryData[] entries, string guid, NetworkObject customer, float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, int pickupScheduleIndex, GameDateTime acceptTime)
		{
		}

		protected override void MinPass()
		{
		}

		private void OnDestroy()
		{
		}

		private void UpdateTiming()
		{
		}

		public override void End()
		{
		}

		public override void Complete(bool network = true)
		{
		}

		public void SetDealer(Dealer dealer)
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

		public bool DoesProductListMatchSpecified(List<ItemInstance> items, bool enforceQuality)
		{
			return false;
		}

		public float GetProductListMatch(List<ItemInstance> items, out int matchedProductCount)
		{
			matchedProductCount = default(int);
			return 0f;
		}

		public override string GetSaveString()
		{
			return null;
		}

		public bool ShouldSave()
		{
			return false;
		}
	}
}
