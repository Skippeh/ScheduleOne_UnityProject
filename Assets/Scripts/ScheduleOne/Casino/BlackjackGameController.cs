using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Casino
{
	public class BlackjackGameController : CasinoGameController
	{
		public enum EStage
		{
			WaitingForPlayers = 0,
			Dealing = 1,
			PlayerTurn = 2,
			DealerTurn = 3,
			Ending = 4
		}

		public enum EPayoutType
		{
			None = 0,
			Blackjack = 1,
			Win = 2,
			Push = 3
		}

		public const int BET_MINIMUM = 10;

		public const int BET_MAXIMUM = 1000;

		public const float PAYOUT_RATIO = 1f;

		public const float BLACKJACK_PAYOUT_RATIO = 1.5f;

		[Header("References")]
		public PlayingCard[] Cards;

		public Transform[] DefaultCardPositions;

		public Transform[] FocusedCameraTransforms;

		public Transform[] FinalCameraTransforms;

		public Transform[] Player1CardPositions;

		public Transform[] Player2CardPositions;

		public Transform[] Player3CardPositions;

		public Transform[] Player4CardPositions;

		public Transform[] DealerCardPositions;

		private List<Player> playersInCurrentRound;

		private List<PlayingCard> playStack;

		private List<PlayingCard> player1Hand;

		private List<PlayingCard> player2Hand;

		private List<PlayingCard> player3Hand;

		private List<PlayingCard> player4Hand;

		private List<PlayingCard> dealerHand;

		private List<PlayingCard.CardData> cardValuesInDeck;

		private List<PlayingCard.CardData> drawnCardsValues;

		protected Transform localFocusCameraTransform;

		protected Transform localFinalCameraTransform;

		public Action onLocalPlayerBetChange;

		public Action onLocalPlayerExitRound;

		public Action onInitialCardsDealt;

		public Action onLocalPlayerReadyForInput;

		public Action onLocalPlayerBust;

		public Action<EPayoutType> onLocalPlayerRoundCompleted;

		private bool roundEnded;

		private Coroutine gameRoutine;

		private bool NetworkInitialize___EarlyScheduleOne_002ECasino_002EBlackjackGameControllerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECasino_002EBlackjackGameControllerAssembly_002DCSharp_002Edll_Excuted;

		public EStage CurrentStage { get; private set; }

		public Player PlayerTurn { get; private set; }

		public float LocalPlayerBet { get; private set; }

		public int DealerScore { get; private set; }

		public int LocalPlayerScore { get; private set; }

		public bool IsLocalPlayerBlackjack { get; private set; }

		public bool IsLocalPlayerBust { get; private set; }

		public bool IsLocalPlayerInCurrentRound => false;

		public override void Awake()
		{
		}

		protected override void Open()
		{
		}

		protected override void Close()
		{
		}

		protected override void Exit(ExitAction action)
		{
		}

		protected override void FixedUpdate()
		{
		}

		private List<Player> GetClockwisePlayers()
		{
			return null;
		}

		[ObserversRpc(RunLocally = true)]
		private void StartGame()
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void NotifyPlayerScore(NetworkObject player, int score, bool blackjack)
		{
		}

		private Transform[] GetPlayerCardPositions(int playerIndex)
		{
			return null;
		}

		[ObserversRpc(RunLocally = true)]
		private void SetRoundEnded(bool ended)
		{
		}

		private void AddCardToPlayerHand(int playerIndex, PlayingCard card)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void AddCardToPlayerHand(int playerindex, string cardID)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void AddCardToDealerHand(string cardID)
		{
		}

		private List<PlayingCard> GetPlayerCards(int playerIndex)
		{
			return null;
		}

		private int GetHandScore(List<PlayingCard> cards, bool countFaceDown = true)
		{
			return 0;
		}

		private int GetCardValue(PlayingCard card, bool aceAsEleven = true)
		{
			return 0;
		}

		private PlayingCard DrawCard()
		{
			return null;
		}

		private void ResetCards()
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void EndGame()
		{
		}

		public void RemoveLocalPlayerFromGame(EPayoutType payout, float cameraDelay = 0f)
		{
		}

		public float GetPayout(float bet, EPayoutType payout)
		{
			return 0f;
		}

		private bool IsCurrentRoundEmpty()
		{
			return false;
		}

		[ObserversRpc(RunLocally = true)]
		private void AddPlayerToCurrentRound(NetworkObject player)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void RequestRemovePlayerFromCurrentRound(NetworkObject player)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void RemovePlayerFromCurrentRound(NetworkObject player)
		{
		}

		public void SetLocalPlayerBet(float bet)
		{
		}

		public bool AreAllPlayersReady()
		{
			return false;
		}

		public int GetPlayersReadyCount()
		{
			return 0;
		}

		public void ToggleLocalPlayerReady()
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

		private void RpcWriter___Observers_StartGame_2166136261()
		{
		}

		private void RpcLogic___StartGame_2166136261()
		{
		}

		private void RpcReader___Observers_StartGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_NotifyPlayerScore_2864061566(NetworkObject player, int score, bool blackjack)
		{
		}

		private void RpcLogic___NotifyPlayerScore_2864061566(NetworkObject player, int score, bool blackjack)
		{
		}

		private void RpcReader___Observers_NotifyPlayerScore_2864061566(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_SetRoundEnded_1140765316(bool ended)
		{
		}

		private void RpcLogic___SetRoundEnded_1140765316(bool ended)
		{
		}

		private void RpcReader___Observers_SetRoundEnded_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_AddCardToPlayerHand_2801973956(int playerindex, string cardID)
		{
		}

		private void RpcLogic___AddCardToPlayerHand_2801973956(int playerindex, string cardID)
		{
		}

		private void RpcReader___Observers_AddCardToPlayerHand_2801973956(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_AddCardToDealerHand_3615296227(string cardID)
		{
		}

		private void RpcLogic___AddCardToDealerHand_3615296227(string cardID)
		{
		}

		private void RpcReader___Observers_AddCardToDealerHand_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_EndGame_2166136261()
		{
		}

		private void RpcLogic___EndGame_2166136261()
		{
		}

		private void RpcReader___Observers_EndGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
		}

		private void RpcLogic___AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
		}

		private void RpcReader___Observers_AddPlayerToCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
		}

		private void RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
		}

		private void RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
		}

		private void RpcLogic___RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
		}

		private void RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ECasino_002EBlackjackGameController_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
