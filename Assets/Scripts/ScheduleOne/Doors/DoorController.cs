namespace ScheduleOne.Doors
{
	public class DoorController : global::FishNet.Object.NetworkBehaviour
	{
		public const float DISTANT_PLAYER_THRESHOLD = 40f;

		public global::ScheduleOne.Doors.EDoorAccess PlayerAccess;

		public bool AutoOpenForPlayer;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Interaction.InteractableObject[] InteriorIntObjs;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Interaction.InteractableObject[] ExteriorIntObjs;

		[global::UnityEngine.Tooltip("Used to block player from entering when the door is open for an NPC, but player isn't permitted access.")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.BoxCollider PlayerBlocker;

		[global::UnityEngine.Header("Animation")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Animation InteriorDoorHandleAnimation;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Animation ExteriorDoorHandleAnimation;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		protected bool AutoCloseOnSleep;

		[global::UnityEngine.SerializeField]
		protected bool AutoCloseOnDistantPlayer;

		[global::UnityEngine.Header("NPC Access")]
		[global::UnityEngine.SerializeField]
		protected bool OpenableByNPCs;

		[global::UnityEngine.Tooltip("How many seconds to wait after NPC passes through to return to original state")]
		[global::UnityEngine.SerializeField]
		protected float ReturnToOriginalTime;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.Doors.EDoorSide> onDoorOpened;

		public global::UnityEngine.Events.UnityEvent onDoorClosed;

		private global::ScheduleOne.Doors.EDoorSide lastOpenSide;

		private bool autoOpenedForPlayer;

		[global::UnityEngine.HideInInspector]
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

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
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

		public bool CanPlayerAccess(global::ScheduleOne.Doors.EDoorSide side)
		{
			return false;
		}

		protected virtual bool CanPlayerAccess(global::ScheduleOne.Doors.EDoorSide side, out string reason)
		{
			reason = null;
			return false;
		}

		public virtual void NPCVicinityDetected(global::ScheduleOne.Doors.EDoorSide side)
		{
		}

		public virtual void PlayerVicinityDetected(global::ScheduleOne.Doors.EDoorSide side)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetIsOpen_Server(bool open, global::ScheduleOne.Doors.EDoorSide accessSide, bool openedForPlayer)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetIsOpen(global::FishNet.Connection.NetworkConnection conn, bool open, global::ScheduleOne.Doors.EDoorSide openSide)
		{
		}

		public virtual void SetIsOpen(bool open, global::ScheduleOne.Doors.EDoorSide openSide)
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

		private void RpcWriter___Server_SetIsOpen_Server_1319291243(bool open, global::ScheduleOne.Doors.EDoorSide accessSide, bool openedForPlayer)
		{
		}

		public void RpcLogic___SetIsOpen_Server_1319291243(bool open, global::ScheduleOne.Doors.EDoorSide accessSide, bool openedForPlayer)
		{
		}

		private void RpcReader___Server_SetIsOpen_Server_1319291243(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetIsOpen_3381113727(global::FishNet.Connection.NetworkConnection conn, bool open, global::ScheduleOne.Doors.EDoorSide openSide)
		{
		}

		public void RpcLogic___SetIsOpen_3381113727(global::FishNet.Connection.NetworkConnection conn, bool open, global::ScheduleOne.Doors.EDoorSide openSide)
		{
		}

		private void RpcReader___Observers_SetIsOpen_3381113727(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetIsOpen_3381113727(global::FishNet.Connection.NetworkConnection conn, bool open, global::ScheduleOne.Doors.EDoorSide openSide)
		{
		}

		private void RpcReader___Target_SetIsOpen_3381113727(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EDoors_002EDoorController_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
