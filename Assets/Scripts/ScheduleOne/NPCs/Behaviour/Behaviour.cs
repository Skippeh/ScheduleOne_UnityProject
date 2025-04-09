using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Management;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Behaviour
{
	public class Behaviour : NetworkBehaviour
	{
		public const int MAX_CONSECUTIVE_PATHING_FAILURES = 5;

		public bool EnabledOnAwake;

		[Header("Settings")]
		public string Name;

		[Tooltip("Behaviour priority; higher = takes priority over lower number behaviour")]
		public int Priority;

		public UnityEvent onEnable;

		public UnityEvent onDisable;

		public UnityEvent onBegin;

		public UnityEvent onEnd;

		protected int consecutivePathingFailures;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public bool Enabled { get; protected set; }

		public bool Started { get; private set; }

		public bool Active { get; private set; }

		public NPCBehaviour beh { get; private set; }

		public NPC Npc => null;

		public virtual void Awake()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		protected override void OnValidate()
		{
		}

		public virtual void Enable()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendEnable()
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void Enable_Networked(NetworkConnection conn)
		{
		}

		public virtual void Disable()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendDisable()
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void Disable_Networked(NetworkConnection conn)
		{
		}

		private void UpdateGameObjectName()
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void Begin_Networked(NetworkConnection conn)
		{
		}

		protected virtual void Begin()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendEnd()
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void End_Networked(NetworkConnection conn)
		{
		}

		protected virtual void End()
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void Pause_Networked(NetworkConnection conn)
		{
		}

		protected virtual void Pause()
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void Resume_Networked(NetworkConnection conn)
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

		protected void SetDestination(ITransitEntity transitEntity, bool teleportIfFail = true)
		{
		}

		protected void SetDestination(Vector3 position, bool teleportIfFail = true)
		{
		}

		protected virtual void WalkCallback(NPCMovement.WalkResult result)
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

		private void RpcReader___Server_SendEnable_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_Enable_Networked_328543758(NetworkConnection conn)
		{
		}

		public void RpcLogic___Enable_Networked_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_Enable_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_Enable_Networked_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Target_Enable_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendDisable_2166136261()
		{
		}

		public void RpcLogic___SendDisable_2166136261()
		{
		}

		private void RpcReader___Server_SendDisable_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_Disable_Networked_328543758(NetworkConnection conn)
		{
		}

		public void RpcLogic___Disable_Networked_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_Disable_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_Disable_Networked_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Target_Disable_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_Begin_Networked_328543758(NetworkConnection conn)
		{
		}

		public void RpcLogic___Begin_Networked_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_Begin_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_Begin_Networked_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Target_Begin_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendEnd_2166136261()
		{
		}

		public void RpcLogic___SendEnd_2166136261()
		{
		}

		private void RpcReader___Server_SendEnd_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_End_Networked_328543758(NetworkConnection conn)
		{
		}

		public void RpcLogic___End_Networked_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_End_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_End_Networked_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Target_End_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_Pause_Networked_328543758(NetworkConnection conn)
		{
		}

		public void RpcLogic___Pause_Networked_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_Pause_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_Pause_Networked_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Target_Pause_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_Resume_Networked_328543758(NetworkConnection conn)
		{
		}

		public void RpcLogic___Resume_Networked_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_Resume_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_Resume_Networked_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Target_Resume_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002EBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
