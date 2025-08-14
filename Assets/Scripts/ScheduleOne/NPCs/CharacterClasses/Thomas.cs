namespace ScheduleOne.NPCs.CharacterClasses
{
	public class Thomas : global::ScheduleOne.NPCs.NPC
	{
		public global::UnityEngine.Sprite MessagingIcon;

		public global::UnityEngine.Events.UnityEvent onMeetingEnded;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ECharacterClasses_002EThomasAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ECharacterClasses_002EThomasAssembly_002DCSharp_002Edll_Excuted;

		public override global::UnityEngine.Sprite GetMessagingIcon()
		{
			return null;
		}

		public void SendIntroMessage()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void MeetingEnded_Server()
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void MeetingEnded()
		{
		}

		protected override void CreateMessageConversation()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void CancelAgreement_Server()
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

		private void RpcWriter___Server_MeetingEnded_Server_2166136261()
		{
		}

		public void RpcLogic___MeetingEnded_Server_2166136261()
		{
		}

		private void RpcReader___Server_MeetingEnded_Server_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_MeetingEnded_2166136261()
		{
		}

		private void RpcLogic___MeetingEnded_2166136261()
		{
		}

		private void RpcReader___Observers_MeetingEnded_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_CancelAgreement_Server_2166136261()
		{
		}

		private void RpcLogic___CancelAgreement_Server_2166136261()
		{
		}

		private void RpcReader___Server_CancelAgreement_Server_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public override void Awake()
		{
		}
	}
}
