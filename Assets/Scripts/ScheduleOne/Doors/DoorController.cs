using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Doors
{
	public class DoorController : NetworkBehaviour
	{
		public const float DISTANT_PLAYER_THRESHOLD = 40f;

		public EDoorAccess PlayerAccess;

		public bool AutoOpenForPlayer;

		[Header("References")]
		[SerializeField]
		protected InteractableObject[] InteriorIntObjs;

		[SerializeField]
		protected InteractableObject[] ExteriorIntObjs;

		[Tooltip("Used to block player from entering when the door is open for an NPC, but player isn't permitted access.")]
		[SerializeField]
		protected BoxCollider PlayerBlocker;

		[Header("Animation")]
		[SerializeField]
		protected Animation InteriorDoorHandleAnimation;

		[SerializeField]
		protected Animation ExteriorDoorHandleAnimation;

		[Header("Settings")]
		[SerializeField]
		protected bool AutoCloseOnSleep;

		[SerializeField]
		protected bool AutoCloseOnDistantPlayer;

		[Header("NPC Access")]
		[SerializeField]
		protected bool OpenableByNPCs;

		[Tooltip("How many seconds to wait after NPC passes through to return to original state")]
		[SerializeField]
		protected float ReturnToOriginalTime;

		public UnityEvent<EDoorSide> onDoorOpened;

		public UnityEvent onDoorClosed;

		private EDoorSide lastOpenSide;

		private bool autoOpenedForPlayer;

		[HideInInspector]
		public string noAccessErrorMessage;

		private bool NetworkInitialize___EarlyScheduleOne_002EDoors_002EDoorControllerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EDoors_002EDoorControllerAssembly_002DCSharp_002Edll_Excuted;

		public bool IsOpen { get; protected set; }

		public bool openedByNPC { get; protected set; }

		public float timeSinceNPCSensed { get; protected set; }

		public bool playerDetectedSinceOpened { get; protected set; }

		public float timeSincePlayerSensed { get; protected set; }

		public float timeInCurrentState { get; protected set; }

		public virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		public virtual void InteriorHandleHovered()
		{
		}

		public virtual void InteriorHandleInteracted()
		{
		}

		public virtual void ExteriorHandleHovered()
		{
		}

		public virtual void ExteriorHandleInteracted()
		{
		}

		public bool CanPlayerAccess(EDoorSide side)
		{
			return false;
		}

		protected virtual bool CanPlayerAccess(EDoorSide side, out string reason)
		{
			reason = null;
			return false;
		}

		public virtual void NPCVicinityDetected(EDoorSide side)
		{
		}

		public virtual void PlayerVicinityDetected(EDoorSide side)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetIsOpen_Server(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetIsOpen(NetworkConnection conn, bool open, EDoorSide openSide)
		{
		}

		public virtual void SetIsOpen(bool open, EDoorSide openSide)
		{
		}

		protected virtual void CheckAutoCloseForDistantPlayer()
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

		private void RpcWriter___Server_SetIsOpen_Server_1319291243(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
		}

		public void RpcLogic___SetIsOpen_Server_1319291243(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
		}

		private void RpcReader___Server_SetIsOpen_Server_1319291243(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
		}

		public void RpcLogic___SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
		}

		private void RpcReader___Observers_SetIsOpen_3381113727(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
		}

		private void RpcReader___Target_SetIsOpen_3381113727(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EDoors_002EDoorController_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
