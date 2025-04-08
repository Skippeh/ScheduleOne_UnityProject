namespace ScheduleOne.Messaging
{
	public class MessagingManager : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.Messaging.MessagingManager>
	{
		protected global::System.Collections.Generic.Dictionary<global::ScheduleOne.NPCs.NPC, global::ScheduleOne.Messaging.MSGConversation> ConversationMap;

		private bool NetworkInitialize___EarlyScheduleOne_002EMessaging_002EMessagingManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EMessaging_002EMessagingManagerAssembly_002DCSharp_002Edll_Excuted;

		public override void Awake()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public global::ScheduleOne.Messaging.MSGConversation GetConversation(global::ScheduleOne.NPCs.NPC npc)
		{
			return null;
		}

		public void Register(global::ScheduleOne.NPCs.NPC npc, global::ScheduleOne.Messaging.MSGConversation convs)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMessage(global::ScheduleOne.Messaging.Message m, bool notify, string npcID)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void ReceiveMessage(global::ScheduleOne.Messaging.Message m, bool notify, string npcID)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMessageChain(global::ScheduleOne.UI.Phone.Messages.MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void ReceiveMessageChain(global::ScheduleOne.UI.Phone.Messages.MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendResponse(int responseIndex, string npcID)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void ReceiveResponse(int responseIndex, string npcID)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPlayerMessage(int sendableIndex, int sentIndex, string npcID)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void ReceivePlayerMessage(int sendableIndex, int sentIndex, string npcID)
		{
		}

		[global::FishNet.Object.TargetRpc]
		private void ReceiveMSGConversationData(global::FishNet.Connection.NetworkConnection conn, string npcID, global::ScheduleOne.Persistence.Datas.MSGConversationData data)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void ClearResponses(string npcID)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void ReceiveClearResponses(string npcID)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void ShowResponses(string npcID, global::System.Collections.Generic.List<global::ScheduleOne.Messaging.Response> responses, float delay)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void ReceiveShowResponses(string npcID, global::System.Collections.Generic.List<global::ScheduleOne.Messaging.Response> responses, float delay)
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

		private void RpcWriter___Server_SendMessage_2134336246(global::ScheduleOne.Messaging.Message m, bool notify, string npcID)
		{
		}

		public void RpcLogic___SendMessage_2134336246(global::ScheduleOne.Messaging.Message m, bool notify, string npcID)
		{
		}

		private void RpcReader___Server_SendMessage_2134336246(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveMessage_2134336246(global::ScheduleOne.Messaging.Message m, bool notify, string npcID)
		{
		}

		private void RpcLogic___ReceiveMessage_2134336246(global::ScheduleOne.Messaging.Message m, bool notify, string npcID)
		{
		}

		private void RpcReader___Observers_ReceiveMessage_2134336246(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendMessageChain_3949292778(global::ScheduleOne.UI.Phone.Messages.MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		public void RpcLogic___SendMessageChain_3949292778(global::ScheduleOne.UI.Phone.Messages.MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		private void RpcReader___Server_SendMessageChain_3949292778(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveMessageChain_3949292778(global::ScheduleOne.UI.Phone.Messages.MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		private void RpcLogic___ReceiveMessageChain_3949292778(global::ScheduleOne.UI.Phone.Messages.MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		private void RpcReader___Observers_ReceiveMessageChain_3949292778(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendResponse_2801973956(int responseIndex, string npcID)
		{
		}

		public void RpcLogic___SendResponse_2801973956(int responseIndex, string npcID)
		{
		}

		private void RpcReader___Server_SendResponse_2801973956(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveResponse_2801973956(int responseIndex, string npcID)
		{
		}

		private void RpcLogic___ReceiveResponse_2801973956(int responseIndex, string npcID)
		{
		}

		private void RpcReader___Observers_ReceiveResponse_2801973956(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendPlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
		}

		public void RpcLogic___SendPlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
		}

		private void RpcReader___Server_SendPlayerMessage_1952281135(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceivePlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
		}

		private void RpcLogic___ReceivePlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
		}

		private void RpcReader___Observers_ReceivePlayerMessage_1952281135(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ReceiveMSGConversationData_2662241369(global::FishNet.Connection.NetworkConnection conn, string npcID, global::ScheduleOne.Persistence.Datas.MSGConversationData data)
		{
		}

		private void RpcLogic___ReceiveMSGConversationData_2662241369(global::FishNet.Connection.NetworkConnection conn, string npcID, global::ScheduleOne.Persistence.Datas.MSGConversationData data)
		{
		}

		private void RpcReader___Target_ReceiveMSGConversationData_2662241369(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_ClearResponses_3615296227(string npcID)
		{
		}

		public void RpcLogic___ClearResponses_3615296227(string npcID)
		{
		}

		private void RpcReader___Server_ClearResponses_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveClearResponses_3615296227(string npcID)
		{
		}

		private void RpcLogic___ReceiveClearResponses_3615296227(string npcID)
		{
		}

		private void RpcReader___Observers_ReceiveClearResponses_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_ShowResponses_995803534(string npcID, global::System.Collections.Generic.List<global::ScheduleOne.Messaging.Response> responses, float delay)
		{
		}

		public void RpcLogic___ShowResponses_995803534(string npcID, global::System.Collections.Generic.List<global::ScheduleOne.Messaging.Response> responses, float delay)
		{
		}

		private void RpcReader___Server_ShowResponses_995803534(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveShowResponses_995803534(string npcID, global::System.Collections.Generic.List<global::ScheduleOne.Messaging.Response> responses, float delay)
		{
		}

		private void RpcLogic___ReceiveShowResponses_995803534(string npcID, global::System.Collections.Generic.List<global::ScheduleOne.Messaging.Response> responses, float delay)
		{
		}

		private void RpcReader___Observers_ReceiveShowResponses_995803534(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EMessaging_002EMessagingManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
