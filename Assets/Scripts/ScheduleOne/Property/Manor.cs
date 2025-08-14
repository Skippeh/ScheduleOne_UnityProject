namespace ScheduleOne.Property
{
	public class Manor : global::ScheduleOne.Property.Property
	{
		public enum EManorState
		{
			Original = 0,
			Destroyed = 1,
			Rebuilt = 2
		}

		public const int REBUILD_AFTER_DAYS = 2;

		public const int REBUILD_DURATION_DAYS = 3;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.GameObject OriginalContainer;

		public global::UnityEngine.GameObject DestroyedContainer;

		public global::UnityEngine.GameObject RebuiltContainer;

		public global::UnityEngine.GameObject DestructionFXContainer;

		public global::UnityEngine.GameObject TunnelBlocker;

		public global::UnityEngine.GameObject TunnelCollapse;

		public global::UnityEngine.GameObject ConstructionContainer;

		public global::ScheduleOne.Audio.AudioSourceController[] ExplosionSounds;

		public global::UnityEngine.GameObject[] DisableOnRebuild;

		public global::System.Action onRebuildComplete;

		private bool NetworkInitialize___EarlyScheduleOne_002EProperty_002EManorAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EProperty_002EManorAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Property.Manor.EManorState ManorState { get; private set; }

		public int DaysSinceStateChange { get; private set; }

		public bool TunnelDug { get; set; }

		public override void Awake()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		protected override void Start()
		{
		}

		protected override void RecieveOwned()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetManorState(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Property.Manor.EManorState state, bool resetStateChangeTimer)
		{
		}

		[global::EasyButtons.Button]
		public void Explode()
		{
		}

		[global::EasyButtons.Button]
		public void Rebuild()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetTunnelDug(global::FishNet.Connection.NetworkConnection conn, bool dug)
		{
		}

		public override bool CanBePurchased()
		{
			return false;
		}

		private void OnSleepEnd()
		{
		}

		public override string GetSaveString()
		{
			return null;
		}

		public override void Load(global::ScheduleOne.Persistence.Datas.PropertyData propertyData, string dataString)
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

		private void RpcWriter___Observers_SetManorState_365422978(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Property.Manor.EManorState state, bool resetStateChangeTimer)
		{
		}

		private void RpcLogic___SetManorState_365422978(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Property.Manor.EManorState state, bool resetStateChangeTimer)
		{
		}

		private void RpcReader___Observers_SetManorState_365422978(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetManorState_365422978(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Property.Manor.EManorState state, bool resetStateChangeTimer)
		{
		}

		private void RpcReader___Target_SetManorState_365422978(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetTunnelDug_214505783(global::FishNet.Connection.NetworkConnection conn, bool dug)
		{
		}

		public void RpcLogic___SetTunnelDug_214505783(global::FishNet.Connection.NetworkConnection conn, bool dug)
		{
		}

		private void RpcReader___Observers_SetTunnelDug_214505783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetTunnelDug_214505783(global::FishNet.Connection.NetworkConnection conn, bool dug)
		{
		}

		private void RpcReader___Target_SetTunnelDug_214505783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EProperty_002EManor_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
