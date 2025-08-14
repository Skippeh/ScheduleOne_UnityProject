namespace ScheduleOne.Misc
{
	public class ModularSwitch : global::FishNet.Object.NetworkBehaviour
	{
		public delegate void ButtonChange(bool isOn);

		public bool isOn;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Interaction.InteractableObject intObj;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform button;

		public global::ScheduleOne.Audio.AudioSourceController OnAudio;

		public global::ScheduleOne.Audio.AudioSourceController OffAudio;

		public global::ScheduleOne.Misc.ToggleableLight[] LightsToControl;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::ScheduleOne.Misc.ModularSwitch> SwitchesToSyncWith;

		public global::ScheduleOne.Misc.ModularSwitch.ButtonChange onToggled;

		public global::UnityEngine.Events.UnityEvent switchedOn;

		public global::UnityEngine.Events.UnityEvent switchedOff;

		private bool NetworkInitialize___EarlyScheduleOne_002EMisc_002EModularSwitchAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EMisc_002EModularSwitchAssembly_002DCSharp_002Edll_Excuted;

		public virtual void Awake()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
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

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SendIsOn(bool isOn)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetIsOn(global::FishNet.Connection.NetworkConnection conn, bool isOn)
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

		private void RpcReader___Server_SendIsOn_1140765316(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetIsOn_214505783(global::FishNet.Connection.NetworkConnection conn, bool isOn)
		{
		}

		private void RpcLogic___SetIsOn_214505783(global::FishNet.Connection.NetworkConnection conn, bool isOn)
		{
		}

		private void RpcReader___Observers_SetIsOn_214505783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetIsOn_214505783(global::FishNet.Connection.NetworkConnection conn, bool isOn)
		{
		}

		private void RpcReader___Target_SetIsOn_214505783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EMisc_002EModularSwitch_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
