using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;

namespace ScheduleOne.Casino
{
	public class CardController : NetworkBehaviour
	{
		private List<PlayingCard> cards;

		private Dictionary<string, PlayingCard> cardDictionary;

		private bool NetworkInitialize___EarlyScheduleOne_002ECasino_002ECardControllerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECasino_002ECardControllerAssembly_002DCSharp_002Edll_Excuted;

		public virtual void Awake()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCardValue(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void SetCardValue(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCardFaceUp(string cardId, bool faceUp)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void SetCardFaceUp(string cardId, bool faceUp)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCardGlide(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void SetCardGlide(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
		}

		private PlayingCard GetCard(string cardId)
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

		private void RpcWriter___Server_SendCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
		}

		public void RpcLogic___SendCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
		}

		private void RpcReader___Server_SendCardValue_3709737967(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
		}

		private void RpcLogic___SetCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
		}

		private void RpcReader___Observers_SetCardValue_3709737967(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendCardFaceUp_310431262(string cardId, bool faceUp)
		{
		}

		public void RpcLogic___SendCardFaceUp_310431262(string cardId, bool faceUp)
		{
		}

		private void RpcReader___Server_SendCardFaceUp_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetCardFaceUp_310431262(string cardId, bool faceUp)
		{
		}

		private void RpcLogic___SetCardFaceUp_310431262(string cardId, bool faceUp)
		{
		}

		private void RpcReader___Observers_SetCardFaceUp_310431262(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
		}

		public void RpcLogic___SendCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
		}

		private void RpcReader___Server_SendCardGlide_2833372058(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
		}

		private void RpcLogic___SetCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
		}

		private void RpcReader___Observers_SetCardGlide_2833372058(PooledReader PooledReader0, Channel channel)
		{
		}

		private void Awake_UserLogic_ScheduleOne_002ECasino_002ECardController_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
