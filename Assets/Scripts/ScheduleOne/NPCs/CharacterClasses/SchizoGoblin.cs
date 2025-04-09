using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.NPCs.CharacterClasses
{
	public class SchizoGoblin : NPC
	{
		private Player targetPlayer;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ECharacterClasses_002ESchizoGoblinAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ECharacterClasses_002ESchizoGoblinAssembly_002DCSharp_002Edll_Excuted;

		[ObserversRpc]
		public void SetTargetPlayer(NetworkObject player)
		{
		}

		public void Activate()
		{
		}

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void RpcWriter___Observers_SetTargetPlayer_3323014238(NetworkObject player)
		{
		}

		public void RpcLogic___SetTargetPlayer_3323014238(NetworkObject player)
		{
		}

		private void RpcReader___Observers_SetTargetPlayer_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
