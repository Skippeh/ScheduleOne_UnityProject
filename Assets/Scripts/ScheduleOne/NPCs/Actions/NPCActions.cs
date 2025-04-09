using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Law;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.NPCs.Actions
{
	public class NPCActions : NetworkBehaviour
	{
		private NPC npc;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EActions_002ENPCActionsAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EActions_002ENPCActionsAssembly_002DCSharp_002Edll_Excuted;

		protected NPCBehaviour behaviour => null;

		public virtual void Awake()
		{
		}

		public void Cower()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CallPolice_Networked(Player player)
		{
		}

		public void SetCallPoliceBehaviourCrime(Crime crime)
		{
		}

		public void FacePlayer(Player player)
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

		private void RpcWriter___Server_CallPolice_Networked_1385486242(Player player)
		{
		}

		public void RpcLogic___CallPolice_Networked_1385486242(Player player)
		{
		}

		private void RpcReader___Server_CallPolice_Networked_1385486242(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EActions_002ENPCActions_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
