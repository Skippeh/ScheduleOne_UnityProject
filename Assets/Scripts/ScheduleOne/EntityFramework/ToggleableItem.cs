using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.EntityFramework
{
	public class ToggleableItem : GridItem
	{
		public enum EStartupAction
		{
			None = 0,
			TurnOn = 1,
			TurnOff = 2,
			Toggle = 3
		}

		[Header("Settings")]
		public EStartupAction StartupAction;

		public UnityEvent onTurnedOn;

		public UnityEvent onTurnedOff;

		public UnityEvent onTurnOnOrOff;

		private bool NetworkInitialize___EarlyScheduleOne_002EEntityFramework_002EToggleableItemAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEntityFramework_002EToggleableItemAssembly_002DCSharp_002Edll_Excuted;

		public bool IsOn { get; private set; }

		public override void Awake()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
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

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SendIsOn(bool on)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetIsOn(NetworkConnection conn, bool on)
		{
		}

		public override string GetSaveString()
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

		private void RpcReader___Server_SendIsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetIsOn_214505783(NetworkConnection conn, bool on)
		{
		}

		private void RpcLogic___SetIsOn_214505783(NetworkConnection conn, bool on)
		{
		}

		private void RpcReader___Observers_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetIsOn_214505783(NetworkConnection conn, bool on)
		{
		}

		private void RpcReader___Target_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EEntityFramework_002EToggleableItem_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
