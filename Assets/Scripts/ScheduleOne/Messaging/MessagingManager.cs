using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Phone.Messages;

namespace ScheduleOne.Messaging
{
	public class MessagingManager : NetworkSingleton<MessagingManager>
	{
		protected Dictionary<NPC, MSGConversation> ConversationMap;

		private bool NetworkInitialize___EarlyScheduleOne_002EMessaging_002EMessagingManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EMessaging_002EMessagingManagerAssembly_002DCSharp_002Edll_Excuted;

		public override void Awake()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		public MSGConversation GetConversation(NPC npc)
		{
			return null;
		}

		public void Register(NPC npc, MSGConversation convs)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMessage(Message m, bool notify, string npcID)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void ReceiveMessage(Message m, bool notify, string npcID)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMessageChain(MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void ReceiveMessageChain(MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendResponse(int responseIndex, string npcID)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void ReceiveResponse(int responseIndex, string npcID)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPlayerMessage(int sendableIndex, int sentIndex, string npcID)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void ReceivePlayerMessage(int sendableIndex, int sentIndex, string npcID)
		{
		}

		[TargetRpc]
		private void ReceiveMSGConversationData(NetworkConnection conn, string npcID, MSGConversationData data)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public void ClearResponses(string npcID)
		{
		}

		[ObserversRpc]
		private void ReceiveClearResponses(string npcID)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void ShowResponses(string npcID, List<Response> responses, float delay)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void ReceiveShowResponses(string npcID, List<Response> responses, float delay)
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

		private void RpcWriter___Server_SendMessage_2134336246(Message m, bool notify, string npcID)
		{
		}

		public void RpcLogic___SendMessage_2134336246(Message m, bool notify, string npcID)
		{
		}

		private void RpcReader___Server_SendMessage_2134336246(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveMessage_2134336246(Message m, bool notify, string npcID)
		{
		}

		private void RpcLogic___ReceiveMessage_2134336246(Message m, bool notify, string npcID)
		{
		}

		private void RpcReader___Observers_ReceiveMessage_2134336246(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		public void RpcLogic___SendMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		private void RpcReader___Server_SendMessageChain_3949292778(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		private void RpcLogic___ReceiveMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		private void RpcReader___Observers_ReceiveMessageChain_3949292778(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendResponse_2801973956(int responseIndex, string npcID)
		{
		}

		public void RpcLogic___SendResponse_2801973956(int responseIndex, string npcID)
		{
		}

		private void RpcReader___Server_SendResponse_2801973956(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveResponse_2801973956(int responseIndex, string npcID)
		{
		}

		private void RpcLogic___ReceiveResponse_2801973956(int responseIndex, string npcID)
		{
		}

		private void RpcReader___Observers_ReceiveResponse_2801973956(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendPlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
		}

		public void RpcLogic___SendPlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
		}

		private void RpcReader___Server_SendPlayerMessage_1952281135(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceivePlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
		}

		private void RpcLogic___ReceivePlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
		}

		private void RpcReader___Observers_ReceivePlayerMessage_1952281135(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_ReceiveMSGConversationData_2662241369(NetworkConnection conn, string npcID, MSGConversationData data)
		{
		}

		private void RpcLogic___ReceiveMSGConversationData_2662241369(NetworkConnection conn, string npcID, MSGConversationData data)
		{
		}

		private void RpcReader___Target_ReceiveMSGConversationData_2662241369(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_ClearResponses_3615296227(string npcID)
		{
		}

		public void RpcLogic___ClearResponses_3615296227(string npcID)
		{
		}

		private void RpcReader___Server_ClearResponses_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveClearResponses_3615296227(string npcID)
		{
		}

		private void RpcLogic___ReceiveClearResponses_3615296227(string npcID)
		{
		}

		private void RpcReader___Observers_ReceiveClearResponses_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_ShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
		}

		public void RpcLogic___ShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
		}

		private void RpcReader___Server_ShowResponses_995803534(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
		}

		private void RpcLogic___ReceiveShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
		}

		private void RpcReader___Observers_ReceiveShowResponses_995803534(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EMessaging_002EMessagingManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
