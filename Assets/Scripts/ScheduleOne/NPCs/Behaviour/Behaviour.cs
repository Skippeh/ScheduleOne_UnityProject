namespace ScheduleOne.NPCs.Behaviour
{
	public class Behaviour : global::FishNet.Object.NetworkBehaviour
	{
		public const int MAX_CONSECUTIVE_PATHING_FAILURES = 5;

		public bool EnabledOnAwake;

		[global::UnityEngine.Header("Settings")]
		public string Name;

		[global::UnityEngine.Tooltip("Behaviour priority; higher = takes priority over lower number behaviour")]
		public int Priority;

		[global::UnityEngine.HideInInspector]
		public int BehaviourIndex;

		public global::UnityEngine.Events.UnityEvent onEnable;

		public global::UnityEngine.Events.UnityEvent onDisable;

		public global::UnityEngine.Events.UnityEvent onBegin;

		public global::UnityEngine.Events.UnityEvent onEnd;

		protected int consecutivePathingFailures;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public bool Enabled { get; protected set; }

		public bool Started { get; private set; }

		public bool Active { get; private set; }

		public global::ScheduleOne.NPCs.Behaviour.NPCBehaviour beh { get; private set; }

		public global::ScheduleOne.NPCs.NPC Npc => null;

		public virtual void Awake()
		{
		}

		protected override void OnValidate()
		{
		}

		public virtual void Enable()
		{
		}

		public void Enable_Server()
		{
		}

		public void Enable_Networked()
		{
		}

		public virtual void Disable()
		{
		}

		public void Disable_Server()
		{
		}

		public void Disable_Networked(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public void Activate_Server(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public virtual void Activate()
		{
		}

		public void Deactivate_Server()
		{
		}

		public void Deactivate_Networked(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public virtual void Deactivate()
		{
		}

		public void Pause_Server()
		{
		}

		public virtual void Pause()
		{
		}

		public void Resume_Server()
		{
		}

		public virtual void Resume()
		{
		}

		public virtual void BehaviourUpdate()
		{
		}

		public virtual void BehaviourLateUpdate()
		{
		}

		public virtual void OnActiveTick()
		{
		}

		protected void SetDestination(global::ScheduleOne.Management.ITransitEntity transitEntity, bool teleportIfFail = true)
		{
		}

		protected virtual void SetDestination(global::UnityEngine.Vector3 position, bool teleportIfFail = true, float successThreshold = 1f)
		{
		}

		protected virtual void WalkCallback(global::ScheduleOne.NPCs.NPCMovement.WalkResult result)
		{
		}

		private void UpdateGameObjectName()
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002EBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
