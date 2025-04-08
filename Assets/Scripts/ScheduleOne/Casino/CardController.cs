namespace ScheduleOne.Casino
{
	public class CardController : global::FishNet.Object.NetworkBehaviour
	{
		private global::System.Collections.Generic.List<global::ScheduleOne.Casino.PlayingCard> cards;

		private global::System.Collections.Generic.Dictionary<string, global::ScheduleOne.Casino.PlayingCard> cardDictionary;

		private bool NetworkInitialize___EarlyScheduleOne_002ECasino_002ECardControllerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECasino_002ECardControllerAssembly_002DCSharp_002Edll_Excuted;

		public virtual void Awake()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCardValue(string cardId, global::ScheduleOne.Casino.PlayingCard.ECardSuit suit, global::ScheduleOne.Casino.PlayingCard.ECardValue value)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetCardValue(string cardId, global::ScheduleOne.Casino.PlayingCard.ECardSuit suit, global::ScheduleOne.Casino.PlayingCard.ECardValue value)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCardFaceUp(string cardId, bool faceUp)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetCardFaceUp(string cardId, bool faceUp)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCardGlide(string cardId, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, float glideTime)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetCardGlide(string cardId, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, float glideTime)
		{
		}

		private global::ScheduleOne.Casino.PlayingCard GetCard(string cardId)
		{
			return null;
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

		private void RpcWriter___Server_SendCardValue_3709737967(string cardId, global::ScheduleOne.Casino.PlayingCard.ECardSuit suit, global::ScheduleOne.Casino.PlayingCard.ECardValue value)
		{
		}

		public void RpcLogic___SendCardValue_3709737967(string cardId, global::ScheduleOne.Casino.PlayingCard.ECardSuit suit, global::ScheduleOne.Casino.PlayingCard.ECardValue value)
		{
		}

		private void RpcReader___Server_SendCardValue_3709737967(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetCardValue_3709737967(string cardId, global::ScheduleOne.Casino.PlayingCard.ECardSuit suit, global::ScheduleOne.Casino.PlayingCard.ECardValue value)
		{
		}

		private void RpcLogic___SetCardValue_3709737967(string cardId, global::ScheduleOne.Casino.PlayingCard.ECardSuit suit, global::ScheduleOne.Casino.PlayingCard.ECardValue value)
		{
		}

		private void RpcReader___Observers_SetCardValue_3709737967(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendCardFaceUp_310431262(string cardId, bool faceUp)
		{
		}

		public void RpcLogic___SendCardFaceUp_310431262(string cardId, bool faceUp)
		{
		}

		private void RpcReader___Server_SendCardFaceUp_310431262(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetCardFaceUp_310431262(string cardId, bool faceUp)
		{
		}

		private void RpcLogic___SetCardFaceUp_310431262(string cardId, bool faceUp)
		{
		}

		private void RpcReader___Observers_SetCardFaceUp_310431262(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendCardGlide_2833372058(string cardId, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, float glideTime)
		{
		}

		public void RpcLogic___SendCardGlide_2833372058(string cardId, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, float glideTime)
		{
		}

		private void RpcReader___Server_SendCardGlide_2833372058(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetCardGlide_2833372058(string cardId, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, float glideTime)
		{
		}

		private void RpcLogic___SetCardGlide_2833372058(string cardId, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, float glideTime)
		{
		}

		private void RpcReader___Observers_SetCardGlide_2833372058(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void Awake_UserLogic_ScheduleOne_002ECasino_002ECardController_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
