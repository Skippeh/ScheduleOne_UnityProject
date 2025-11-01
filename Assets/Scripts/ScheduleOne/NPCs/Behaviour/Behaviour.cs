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

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendEnable()
		{
		}

		public void Enable_Networked(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void Enable_Client(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public virtual void Disable()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendDisable()
		{
		}

		public void Disable_Networked(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void Disable_Client(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void UpdateGameObjectName()
		{
		}

		public void Begin_Networked(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void Begin_Client(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		protected virtual void Begin()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendEnd()
		{
		}

		public void End_Networked(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void End_Client(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		protected virtual void End()
		{
		}

		public void Pause_Networked(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void Pause_Client(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		protected virtual void Pause()
		{
		}

		public void Resume_Networked(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void Resume_Client(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		protected virtual void Resume()
		{
		}

		public virtual void BehaviourUpdate()
		{
		}

		public virtual void BehaviourLateUpdate()
		{
		}

		public virtual void ActiveMinPass()
		{
		}

		protected void SetPriority(int p)
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

		public virtual void NetworkInitialize___Early()
		{
		}

		public virtual void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void RpcWriter___Server_SendEnable_2166136261()
		{
		}

		public void RpcLogic___SendEnable_2166136261()
		{
		}

		private void RpcReader___Server_SendEnable_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_Enable_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcLogic___Enable_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_Enable_Client_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_Enable_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Target_Enable_Client_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendDisable_2166136261()
		{
		}

		public void RpcLogic___SendDisable_2166136261()
		{
		}

		private void RpcReader___Server_SendDisable_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_Disable_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcLogic___Disable_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_Disable_Client_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_Disable_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Target_Disable_Client_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_Begin_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcLogic___Begin_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_Begin_Client_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_Begin_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Target_Begin_Client_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendEnd_2166136261()
		{
		}

		public void RpcLogic___SendEnd_2166136261()
		{
		}

		private void RpcReader___Server_SendEnd_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_End_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcLogic___End_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_End_Client_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_End_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Target_End_Client_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_Pause_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcLogic___Pause_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_Pause_Client_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_Pause_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Target_Pause_Client_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_Resume_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcLogic___Resume_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_Resume_Client_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_Resume_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Target_Resume_Client_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002EBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
