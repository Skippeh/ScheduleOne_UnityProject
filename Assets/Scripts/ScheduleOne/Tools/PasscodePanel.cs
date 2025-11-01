namespace ScheduleOne.Tools
{
	public class PasscodePanel : global::FishNet.Object.NetworkBehaviour
	{
		public const int PasscodeLength = 4;

		[global::UnityEngine.Header("Settings")]
		public string CorrectPasscode;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Interaction.InteractableObject[] Buttons;

		public global::TMPro.TextMeshPro CodeLabel;

		public global::UnityEngine.Events.UnityEvent onButtonPressed;

		public global::UnityEngine.Events.UnityEvent onCorrect;

		public global::UnityEngine.Events.UnityEvent onIncorrect;

		private string enteredPasscode;

		private bool NetworkInitialize___EarlyScheduleOne_002ETools_002EPasscodePanelAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ETools_002EPasscodePanelAssembly_002DCSharp_002Edll_Excuted;

		public virtual void Awake()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		private void OnButtonPressed(int number)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void OnButtonPressed_Server(int number)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void RegisterButtonPress(int number)
		{
		}

		public void SetIsUsable(bool isUsable)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		[global::FishNet.Object.TargetRpc]
		private void SetEnteredPasscode(global::FishNet.Connection.NetworkConnection conn, string passcode)
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

		private void RpcWriter___Server_OnButtonPressed_Server_3316948804(int number)
		{
		}

		private void RpcLogic___OnButtonPressed_Server_3316948804(int number)
		{
		}

		private void RpcReader___Server_OnButtonPressed_Server_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_RegisterButtonPress_3316948804(int number)
		{
		}

		private void RpcLogic___RegisterButtonPress_3316948804(int number)
		{
		}

		private void RpcReader___Observers_RegisterButtonPress_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetEnteredPasscode_2971853958(global::FishNet.Connection.NetworkConnection conn, string passcode)
		{
		}

		private void RpcLogic___SetEnteredPasscode_2971853958(global::FishNet.Connection.NetworkConnection conn, string passcode)
		{
		}

		private void RpcReader___Observers_SetEnteredPasscode_2971853958(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetEnteredPasscode_2971853958(global::FishNet.Connection.NetworkConnection conn, string passcode)
		{
		}

		private void RpcReader___Target_SetEnteredPasscode_2971853958(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void Awake_UserLogic_ScheduleOne_002ETools_002EPasscodePanel_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
