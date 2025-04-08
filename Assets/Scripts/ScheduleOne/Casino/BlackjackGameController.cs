namespace ScheduleOne.Casino
{
	public class BlackjackGameController : global::ScheduleOne.Casino.CasinoGameController
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

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Casino.PlayingCard[] Cards;

		public global::UnityEngine.Transform[] DefaultCardPositions;

		public global::UnityEngine.Transform[] FocusedCameraTransforms;

		public global::UnityEngine.Transform[] FinalCameraTransforms;

		public global::UnityEngine.Transform[] Player1CardPositions;

		public global::UnityEngine.Transform[] Player2CardPositions;

		public global::UnityEngine.Transform[] Player3CardPositions;

		public global::UnityEngine.Transform[] Player4CardPositions;

		public global::UnityEngine.Transform[] DealerCardPositions;

		private global::System.Collections.Generic.List<global::ScheduleOne.PlayerScripts.Player> playersInCurrentRound;

		private global::System.Collections.Generic.List<global::ScheduleOne.Casino.PlayingCard> playStack;

		private global::System.Collections.Generic.List<global::ScheduleOne.Casino.PlayingCard> player1Hand;

		private global::System.Collections.Generic.List<global::ScheduleOne.Casino.PlayingCard> player2Hand;

		private global::System.Collections.Generic.List<global::ScheduleOne.Casino.PlayingCard> player3Hand;

		private global::System.Collections.Generic.List<global::ScheduleOne.Casino.PlayingCard> player4Hand;

		private global::System.Collections.Generic.List<global::ScheduleOne.Casino.PlayingCard> dealerHand;

		private global::System.Collections.Generic.List<global::ScheduleOne.Casino.PlayingCard.CardData> cardValuesInDeck;

		private global::System.Collections.Generic.List<global::ScheduleOne.Casino.PlayingCard.CardData> drawnCardsValues;

		protected global::UnityEngine.Transform localFocusCameraTransform;

		protected global::UnityEngine.Transform localFinalCameraTransform;

		public global::System.Action onLocalPlayerBetChange;

		public global::System.Action onLocalPlayerExitRound;

		public global::System.Action onInitialCardsDealt;

		public global::System.Action onLocalPlayerReadyForInput;

		public global::System.Action onLocalPlayerBust;

		public global::System.Action<global::ScheduleOne.Casino.BlackjackGameController.EPayoutType> onLocalPlayerRoundCompleted;

		private bool roundEnded;

		private global::UnityEngine.Coroutine gameRoutine;

		private bool NetworkInitialize___EarlyScheduleOne_002ECasino_002EBlackjackGameControllerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECasino_002EBlackjackGameControllerAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Casino.BlackjackGameController.EStage CurrentStage { get; private set; }

		public global::ScheduleOne.PlayerScripts.Player PlayerTurn { get; private set; }

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

		protected override void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		protected override void FixedUpdate()
		{
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.PlayerScripts.Player> GetClockwisePlayers()
		{
			return null;
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void StartGame()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void NotifyPlayerScore(global::FishNet.Object.NetworkObject player, int score, bool blackjack)
		{
		}

		private global::UnityEngine.Transform[] GetPlayerCardPositions(int playerIndex)
		{
			return null;
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetRoundEnded(bool ended)
		{
		}

		private void AddCardToPlayerHand(int playerIndex, global::ScheduleOne.Casino.PlayingCard card)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void AddCardToPlayerHand(int playerindex, string cardID)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void AddCardToDealerHand(string cardID)
		{
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.Casino.PlayingCard> GetPlayerCards(int playerIndex)
		{
			return null;
		}

		private int GetHandScore(global::System.Collections.Generic.List<global::ScheduleOne.Casino.PlayingCard> cards, bool countFaceDown = true)
		{
			return 0;
		}

		private int GetCardValue(global::ScheduleOne.Casino.PlayingCard card, bool aceAsEleven = true)
		{
			return 0;
		}

		private global::ScheduleOne.Casino.PlayingCard DrawCard()
		{
			return null;
		}

		private void ResetCards()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void EndGame()
		{
		}

		public void RemoveLocalPlayerFromGame(global::ScheduleOne.Casino.BlackjackGameController.EPayoutType payout, float cameraDelay = 0f)
		{
		}

		public float GetPayout(float bet, global::ScheduleOne.Casino.BlackjackGameController.EPayoutType payout)
		{
			return 0f;
		}

		private bool IsCurrentRoundEmpty()
		{
			return false;
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void AddPlayerToCurrentRound(global::FishNet.Object.NetworkObject player)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void RequestRemovePlayerFromCurrentRound(global::FishNet.Object.NetworkObject player)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void RemovePlayerFromCurrentRound(global::FishNet.Object.NetworkObject player)
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

		private void RpcReader___Observers_StartGame_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_NotifyPlayerScore_2864061566(global::FishNet.Object.NetworkObject player, int score, bool blackjack)
		{
		}

		private void RpcLogic___NotifyPlayerScore_2864061566(global::FishNet.Object.NetworkObject player, int score, bool blackjack)
		{
		}

		private void RpcReader___Observers_NotifyPlayerScore_2864061566(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetRoundEnded_1140765316(bool ended)
		{
		}

		private void RpcLogic___SetRoundEnded_1140765316(bool ended)
		{
		}

		private void RpcReader___Observers_SetRoundEnded_1140765316(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_AddCardToPlayerHand_2801973956(int playerindex, string cardID)
		{
		}

		private void RpcLogic___AddCardToPlayerHand_2801973956(int playerindex, string cardID)
		{
		}

		private void RpcReader___Observers_AddCardToPlayerHand_2801973956(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_AddCardToDealerHand_3615296227(string cardID)
		{
		}

		private void RpcLogic___AddCardToDealerHand_3615296227(string cardID)
		{
		}

		private void RpcReader___Observers_AddCardToDealerHand_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_EndGame_2166136261()
		{
		}

		private void RpcLogic___EndGame_2166136261()
		{
		}

		private void RpcReader___Observers_EndGame_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_AddPlayerToCurrentRound_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		private void RpcLogic___AddPlayerToCurrentRound_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		private void RpcReader___Observers_AddPlayerToCurrentRound_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		private void RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		private void RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		private void RpcLogic___RemovePlayerFromCurrentRound_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		private void RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ECasino_002EBlackjackGameController_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
