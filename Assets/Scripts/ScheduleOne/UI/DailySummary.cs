namespace ScheduleOne.UI
{
	public class DailySummary : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.UI.DailySummary>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform Container;

		public global::UnityEngine.Animation Anim;

		public global::TMPro.TextMeshProUGUI TitleLabel;

		public global::UnityEngine.RectTransform[] ProductEntries;

		public global::TMPro.TextMeshProUGUI PlayerEarningsLabel;

		public global::TMPro.TextMeshProUGUI DealerEarningsLabel;

		public global::TMPro.TextMeshProUGUI XPGainedLabel;

		public global::UnityEngine.Events.UnityEvent onClosed;

		private global::System.Collections.Generic.Dictionary<string, int> itemsSoldByPlayer;

		private float moneyEarnedByPlayer;

		private float moneyEarnedByDealers;

		private bool NetworkInitialize___EarlyScheduleOne_002EUI_002EDailySummaryAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EUI_002EDailySummaryAssembly_002DCSharp_002Edll_Excuted;

		public bool IsOpen { get; private set; }

		public int xpGained { get; private set; }

		protected override void Start()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		private void SleepEnd()
		{
		}

		[global::FishNet.Object.ObserversRpc]
		public void AddSoldItem(string id, int amount)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		public void AddPlayerMoney(float amount)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		public void AddDealerMoney(float amount)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		public void AddXP(int xp)
		{
		}

		private void ClearStats()
		{
		}

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void RpcWriter___Observers_AddSoldItem_3643459082(string id, int amount)
		{
		}

		public void RpcLogic___AddSoldItem_3643459082(string id, int amount)
		{
		}

		private void RpcReader___Observers_AddSoldItem_3643459082(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_AddPlayerMoney_431000436(float amount)
		{
		}

		public void RpcLogic___AddPlayerMoney_431000436(float amount)
		{
		}

		private void RpcReader___Observers_AddPlayerMoney_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_AddDealerMoney_431000436(float amount)
		{
		}

		public void RpcLogic___AddDealerMoney_431000436(float amount)
		{
		}

		private void RpcReader___Observers_AddDealerMoney_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_AddXP_3316948804(int xp)
		{
		}

		public void RpcLogic___AddXP_3316948804(int xp)
		{
		}

		private void RpcReader___Observers_AddXP_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
