namespace ScheduleOne.NPCs.CharacterClasses
{
	public class SchizoGoblin : global::ScheduleOne.NPCs.NPC
	{
		private global::ScheduleOne.PlayerScripts.Player targetPlayer;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ECharacterClasses_002ESchizoGoblinAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ECharacterClasses_002ESchizoGoblinAssembly_002DCSharp_002Edll_Excuted;

		[global::FishNet.Object.ObserversRpc]
		public void SetTargetPlayer(global::FishNet.Object.NetworkObject player)
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

		private void RpcWriter___Observers_SetTargetPlayer_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		public void RpcLogic___SetTargetPlayer_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		private void RpcReader___Observers_SetTargetPlayer_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
