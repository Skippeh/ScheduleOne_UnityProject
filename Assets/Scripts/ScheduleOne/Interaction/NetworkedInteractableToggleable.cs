namespace ScheduleOne.Interaction
{
	public class NetworkedInteractableToggleable : global::FishNet.Object.NetworkBehaviour
	{
		public string ActivateMessage;

		public string DeactivateMessage;

		public float CoolDown;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.Events.UnityEvent onToggle;

		public global::UnityEngine.Events.UnityEvent onActivate;

		public global::UnityEngine.Events.UnityEvent onDeactivate;

		private float lastActivated;

		private bool NetworkInitialize___EarlyScheduleOne_002EInteraction_002ENetworkedInteractableToggleableAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EInteraction_002ENetworkedInteractableToggleableAssembly_002DCSharp_002Edll_Excuted;

		public bool IsActivated { get; private set; }

		public void Start()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendToggle()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetState(global::FishNet.Connection.NetworkConnection conn, bool activated)
		{
		}

		public void PoliceDetected()
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

		private void RpcWriter___Server_SendToggle_2166136261()
		{
		}

		public void RpcLogic___SendToggle_2166136261()
		{
		}

		private void RpcReader___Server_SendToggle_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetState_214505783(global::FishNet.Connection.NetworkConnection conn, bool activated)
		{
		}

		public void RpcLogic___SetState_214505783(global::FishNet.Connection.NetworkConnection conn, bool activated)
		{
		}

		private void RpcReader___Observers_SetState_214505783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetState_214505783(global::FishNet.Connection.NetworkConnection conn, bool activated)
		{
		}

		private void RpcReader___Target_SetState_214505783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual void Awake()
		{
		}
	}
}
