using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Misc
{
	public class ModularSwitch : NetworkBehaviour
	{
		public delegate void ButtonChange(bool isOn);

		public bool isOn;

		[Header("References")]
		[SerializeField]
		protected InteractableObject intObj;

		[SerializeField]
		protected Transform button;

		public AudioSourceController OnAudio;

		public AudioSourceController OffAudio;

		[Header("Settings")]
		[SerializeField]
		protected List<ModularSwitch> SwitchesToSyncWith;

		public ButtonChange onToggled;

		public UnityEvent switchedOn;

		public UnityEvent switchedOff;

		private bool NetworkInitialize___EarlyScheduleOne_002EMisc_002EModularSwitchAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EMisc_002EModularSwitchAssembly_002DCSharp_002Edll_Excuted;

		public virtual void Awake()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		protected virtual void LateUpdate()
		{
		}

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SendIsOn(bool isOn)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetIsOn(NetworkConnection conn, bool isOn)
		{
		}

		public void SwitchOn()
		{
		}

		public void SwitchOff()
		{
		}

		public virtual void NetworkInitialize___Early()
		{
		}

		public virtual void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void RpcWriter___Server_SendIsOn_1140765316(bool isOn)
		{
		}

		private void RpcLogic___SendIsOn_1140765316(bool isOn)
		{
		}

		private void RpcReader___Server_SendIsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetIsOn_214505783(NetworkConnection conn, bool isOn)
		{
		}

		private void RpcLogic___SetIsOn_214505783(NetworkConnection conn, bool isOn)
		{
		}

		private void RpcReader___Observers_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetIsOn_214505783(NetworkConnection conn, bool isOn)
		{
		}

		private void RpcReader___Target_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EMisc_002EModularSwitch_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
