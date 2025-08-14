namespace ScheduleOne.Money
{
	public class MoneyManager : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.Money.MoneyManager>, global::ScheduleOne.Persistence.IBaseSaveable, global::ScheduleOne.Persistence.ISaveable
	{
		public class FloatContainer
		{
			public float value { get; private set; }

			public void ChangeValue(float value)
			{
			}
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CShowCashChange_003Ed__64 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::UnityEngine.RectTransform changeDisplay;

			private global::TMPro.TextMeshProUGUI _003Ctext_003E5__2;

			private float _003CstartVert_003E5__3;

			private float _003ClerpTime_003E5__4;

			private float _003CvertOffset_003E5__5;

			private float _003Ci_003E5__6;

			object global::System.Collections.Generic.IEnumerator<object>.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			object global::System.Collections.IEnumerator.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			[global::System.Diagnostics.DebuggerHidden]
			public _003CShowCashChange_003Ed__64(int _003C_003E1__state)
			{
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool global::System.Collections.IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.Collections.IEnumerator.Reset()
			{
			}
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CShowOnlineBalanceChange_003Ed__61 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::UnityEngine.RectTransform changeDisplay;

			private global::TMPro.TextMeshProUGUI _003Ctext_003E5__2;

			private float _003CstartVert_003E5__3;

			private float _003ClerpTime_003E5__4;

			private float _003CvertOffset_003E5__5;

			private float _003Ci_003E5__6;

			object global::System.Collections.Generic.IEnumerator<object>.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			object global::System.Collections.IEnumerator.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			[global::System.Diagnostics.DebuggerHidden]
			public _003CShowOnlineBalanceChange_003Ed__61(int _003C_003E1__state)
			{
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool global::System.Collections.IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.Collections.IEnumerator.Reset()
			{
			}
		}

		public const string MONEY_TEXT_COLOR = "#54E717";

		public const string MONEY_TEXT_COLOR_DARKER = "#46CB4F";

		public const string ONLINE_BALANCE_COLOR = "#4CBFFF";

		public global::System.Collections.Generic.List<global::ScheduleOne.Money.Transaction> ledger;

		[global::FishNet.Object.Synchronizing.SyncVar(WritePermissions = global::FishNet.Object.Synchronizing.WritePermission.ClientUnsynchronized)]
		public float onlineBalance;

		[global::FishNet.Object.Synchronizing.SyncVar(WritePermissions = global::FishNet.Object.Synchronizing.WritePermission.ClientUnsynchronized)]
		public float lifetimeEarnings;

		public global::ScheduleOne.Audio.AudioSourceController CashSound;

		[global::UnityEngine.Header("Prefabs")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject moneyChangePrefab;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject cashChangePrefab;

		public global::UnityEngine.Sprite LaunderingNotificationIcon;

		public global::System.Action<global::ScheduleOne.Money.MoneyManager.FloatContainer> onNetworthCalculation;

		private global::ScheduleOne.Persistence.Loaders.MoneyLoader loader;

		public global::FishNet.Object.Synchronizing.SyncVar<float> syncVar___onlineBalance;

		public global::FishNet.Object.Synchronizing.SyncVar<float> syncVar___lifetimeEarnings;

		private bool NetworkInitialize___EarlyScheduleOne_002EMoney_002EMoneyManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EMoney_002EMoneyManagerAssembly_002DCSharp_002Edll_Excuted;

		public float LifetimeEarnings => 0f;

		public float LastCalculatedNetworth { get; protected set; }

		public float cashBalance => 0f;

		protected global::ScheduleOne.ItemFramework.CashInstance cashInstance => null;

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public int LoadOrder { get; }

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

		public static string ApplyMoneyTextColor(string text)
		{
			return null;
		}

		public static string ApplyMoneyTextColorDarker(string text)
		{
			return null;
		}

		public static string ApplyOnlineBalanceColor(string text)
		{
			return null;
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

		public global::ScheduleOne.ItemFramework.CashInstance GetCashInstance(float amount)
		{
			return null;
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateOnlineTransaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void ReceiveOnlineTransaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Money.MoneyManager._003CShowOnlineBalanceChange_003Ed__61))]
		protected global::System.Collections.IEnumerator ShowOnlineBalanceChange(global::UnityEngine.RectTransform changeDisplay)
		{
			return null;
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void ChangeLifetimeEarnings(float change)
		{
		}

		public void ChangeCashBalance(float change, bool visualizeChange = true, bool playCashSound = false)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Money.MoneyManager._003CShowCashChange_003Ed__64))]
		protected global::System.Collections.IEnumerator ShowCashChange(global::UnityEngine.RectTransform changeDisplay)
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

		public void Load(global::ScheduleOne.Persistence.Datas.MoneyData data)
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

		private void RpcReader___Server_CreateOnlineTransaction_1419830531(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		private void RpcLogic___ReceiveOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		private void RpcReader___Observers_ReceiveOnlineTransaction_1419830531(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_ChangeLifetimeEarnings_431000436(float change)
		{
		}

		public void RpcLogic___ChangeLifetimeEarnings_431000436(float change)
		{
		}

		private void RpcReader___Server_ChangeLifetimeEarnings_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EMoney_002EMoneyManager(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EMoney_002EMoneyManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
