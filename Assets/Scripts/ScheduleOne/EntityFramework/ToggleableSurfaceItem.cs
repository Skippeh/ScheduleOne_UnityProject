namespace ScheduleOne.EntityFramework
{
	public class ToggleableSurfaceItem : global::ScheduleOne.EntityFramework.SurfaceItem
	{
		public enum EStartupAction
		{
			None = 0,
			TurnOn = 1,
			TurnOff = 2,
			Toggle = 3
		}

		[global::UnityEngine.Header("Settings")]
		public global::ScheduleOne.EntityFramework.ToggleableSurfaceItem.EStartupAction StartupAction;

		public global::UnityEngine.Events.UnityEvent onTurnedOn;

		public global::UnityEngine.Events.UnityEvent onTurnedOff;

		public global::UnityEngine.Events.UnityEvent onTurnOnOrOff;

		private bool NetworkInitialize___EarlyScheduleOne_002EEntityFramework_002EToggleableSurfaceItemAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEntityFramework_002EToggleableSurfaceItemAssembly_002DCSharp_002Edll_Excuted;

		public bool IsOn { get; private set; }

		public override void Awake()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void Toggle()
		{
		}

		public void TurnOn(bool network = true)
		{
		}

		public void TurnOff(bool network = true)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SendIsOn(bool on)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetIsOn(global::FishNet.Connection.NetworkConnection conn, bool on)
		{
		}

		public override global::ScheduleOne.Persistence.Datas.BuildableItemData GetBaseData()
		{
			return null;
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

		private void RpcWriter___Server_SendIsOn_1140765316(bool on)
		{
		}

		private void RpcLogic___SendIsOn_1140765316(bool on)
		{
		}

		private void RpcReader___Server_SendIsOn_1140765316(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetIsOn_214505783(global::FishNet.Connection.NetworkConnection conn, bool on)
		{
		}

		private void RpcLogic___SetIsOn_214505783(global::FishNet.Connection.NetworkConnection conn, bool on)
		{
		}

		private void RpcReader___Observers_SetIsOn_214505783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetIsOn_214505783(global::FishNet.Connection.NetworkConnection conn, bool on)
		{
		}

		private void RpcReader___Target_SetIsOn_214505783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EEntityFramework_002EToggleableSurfaceItem_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
