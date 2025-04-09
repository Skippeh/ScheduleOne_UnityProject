using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Interaction
{
	public class NetworkedInteractableToggleable : NetworkBehaviour
	{
		public string ActivateMessage;

		public string DeactivateMessage;

		public float CoolDown;

		[Header("References")]
		public InteractableObject IntObj;

		public UnityEvent onToggle;

		public UnityEvent onActivate;

		public UnityEvent onDeactivate;

		private float lastActivated;

		private bool NetworkInitialize___EarlyScheduleOne_002EInteraction_002ENetworkedInteractableToggleableAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EInteraction_002ENetworkedInteractableToggleableAssembly_002DCSharp_002Edll_Excuted;

		public bool IsActivated { get; private set; }

		public void Start()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendToggle()
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetState(NetworkConnection conn, bool activated)
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

		private void RpcReader___Server_SendToggle_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetState_214505783(NetworkConnection conn, bool activated)
		{
		}

		public void RpcLogic___SetState_214505783(NetworkConnection conn, bool activated)
		{
		}

		private void RpcReader___Observers_SetState_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetState_214505783(NetworkConnection conn, bool activated)
		{
		}

		private void RpcReader___Target_SetState_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		public virtual void Awake()
		{
		}
	}
}
