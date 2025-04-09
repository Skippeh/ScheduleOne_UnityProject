using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Money
{
	public class MoneyManager : NetworkSingleton<MoneyManager>, IBaseSaveable, ISaveable
	{
		public class FloatContainer
		{
			public float value { get; private set; }

			public void ChangeValue(float value)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CShowCashChange_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RectTransform changeDisplay;

			private TextMeshProUGUI _003Ctext_003E5__2;

			private float _003CstartVert_003E5__3;

			private float _003ClerpTime_003E5__4;

			private float _003CvertOffset_003E5__5;

			private float _003Ci_003E5__6;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CShowCashChange_003Ed__58(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CShowOnlineBalanceChange_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RectTransform changeDisplay;

			private TextMeshProUGUI _003Ctext_003E5__2;

			private float _003CstartVert_003E5__3;

			private float _003ClerpTime_003E5__4;

			private float _003CvertOffset_003E5__5;

			private float _003Ci_003E5__6;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CShowOnlineBalanceChange_003Ed__55(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public const string MONEY_TEXT_COLOR = "#54E717";

		public const string MONEY_TEXT_COLOR_DARKER = "#46CB4F";

		public const string ONLINE_BALANCE_COLOR = "#4CBFFF";

		public List<Transaction> ledger;

		[SyncVar(WritePermissions = WritePermission.ClientUnsynchronized)]
		public float onlineBalance;

		[SyncVar(WritePermissions = WritePermission.ClientUnsynchronized)]
		public float lifetimeEarnings;

		public AudioSourceController CashSound;

		[Header("Prefabs")]
		[SerializeField]
		protected GameObject moneyChangePrefab;

		[SerializeField]
		protected GameObject cashChangePrefab;

		public Sprite LaunderingNotificationIcon;

		public Action<FloatContainer> onNetworthCalculation;

		private MoneyLoader loader;

		public SyncVar<float> syncVar___onlineBalance;

		public SyncVar<float> syncVar___lifetimeEarnings;

		private bool NetworkInitialize___EarlyScheduleOne_002EMoney_002EMoneyManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EMoney_002EMoneyManagerAssembly_002DCSharp_002Edll_Excuted;

		public float LifetimeEarnings => 0f;

		public float LastCalculatedNetworth { get; protected set; }

		public float cashBalance => 0f;

		protected CashInstance cashInstance => null;

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public List<string> LocalExtraFiles { get; set; }

		public List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public float SyncAccessor_onlineBalance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SyncAccessor_lifetimeEarnings
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override void Awake()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		protected override void Start()
		{
		}

		public override void OnStartServer()
		{
		}

		public override void OnStartClient()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void Loaded()
		{
		}

		private void Update()
		{
		}

		private void MinPass()
		{
		}

		public CashInstance GetCashInstance(float amount)
		{
			return null;
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateOnlineTransaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		[ObserversRpc]
		private void ReceiveOnlineTransaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		[IteratorStateMachine(typeof(_003CShowOnlineBalanceChange_003Ed__55))]
		protected IEnumerator ShowOnlineBalanceChange(RectTransform changeDisplay)
		{
			return null;
		}

		[ServerRpc(RequireOwnership = false)]
		public void ChangeLifetimeEarnings(float change)
		{
		}

		public void ChangeCashBalance(float change, bool visualizeChange = true, bool playCashSound = false)
		{
		}

		[IteratorStateMachine(typeof(_003CShowCashChange_003Ed__58))]
		protected IEnumerator ShowCashChange(RectTransform changeDisplay)
		{
			return null;
		}

		public static string FormatAmount(float amount, bool showDecimals = false, bool includeColor = false)
		{
			return null;
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public void Load(MoneyData data)
		{
		}

		public void CheckNetworthAchievements()
		{
		}

		public float GetNetWorth()
		{
			return 0f;
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

		private void RpcWriter___Server_CreateOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		public void RpcLogic___CreateOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		private void RpcReader___Server_CreateOnlineTransaction_1419830531(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		private void RpcLogic___ReceiveOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		private void RpcReader___Observers_ReceiveOnlineTransaction_1419830531(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_ChangeLifetimeEarnings_431000436(float change)
		{
		}

		public void RpcLogic___ChangeLifetimeEarnings_431000436(float change)
		{
		}

		private void RpcReader___Server_ChangeLifetimeEarnings_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EMoney_002EMoneyManager(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EMoney_002EMoneyManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
