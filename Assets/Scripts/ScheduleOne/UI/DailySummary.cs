using System.Collections.Generic;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	public class DailySummary : NetworkSingleton<DailySummary>
	{
		[Header("References")]
		public Canvas Canvas;

		public RectTransform Container;

		public Animation Anim;

		public TextMeshProUGUI TitleLabel;

		public RectTransform[] ProductEntries;

		public TextMeshProUGUI PlayerEarningsLabel;

		public TextMeshProUGUI DealerEarningsLabel;

		public TextMeshProUGUI XPGainedLabel;

		public UnityEvent onClosed;

		private Dictionary<string, int> itemsSoldByPlayer;

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

		[ObserversRpc]
		public void AddSoldItem(string id, int amount)
		{
		}

		[ObserversRpc]
		public void AddPlayerMoney(float amount)
		{
		}

		[ObserversRpc]
		public void AddDealerMoney(float amount)
		{
		}

		[ObserversRpc]
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

		private void RpcReader___Observers_AddSoldItem_3643459082(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_AddPlayerMoney_431000436(float amount)
		{
		}

		public void RpcLogic___AddPlayerMoney_431000436(float amount)
		{
		}

		private void RpcReader___Observers_AddPlayerMoney_431000436(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_AddDealerMoney_431000436(float amount)
		{
		}

		public void RpcLogic___AddDealerMoney_431000436(float amount)
		{
		}

		private void RpcReader___Observers_AddDealerMoney_431000436(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_AddXP_3316948804(int xp)
		{
		}

		public void RpcLogic___AddXP_3316948804(int xp)
		{
		}

		private void RpcReader___Observers_AddXP_3316948804(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
