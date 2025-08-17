namespace ScheduleOne.NPCs.Actions
{
	public class NPCActions : global::FishNet.Object.NetworkBehaviour
	{
		private global::ScheduleOne.NPCs.NPC npc;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EActions_002ENPCActionsAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EActions_002ENPCActionsAssembly_002DCSharp_002Edll_Excuted;

		protected global::ScheduleOne.NPCs.Behaviour.NPCBehaviour behaviour => null;

		public virtual void Awake()
		{
		}

		public void Cower()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CallPolice_Networked(global::FishNet.Object.NetworkObject playerObj)
		{
		}

		public void SetCallPoliceBehaviourCrime(global::ScheduleOne.Law.Crime crime)
		{
		}

		public void FacePlayer(global::ScheduleOne.PlayerScripts.Player player)
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

		private void RpcWriter___Server_CallPolice_Networked_3323014238(global::FishNet.Object.NetworkObject playerObj)
		{
		}

		public void RpcLogic___CallPolice_Networked_3323014238(global::FishNet.Object.NetworkObject playerObj)
		{
		}

		private void RpcReader___Server_CallPolice_Networked_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EActions_002ENPCActions_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
