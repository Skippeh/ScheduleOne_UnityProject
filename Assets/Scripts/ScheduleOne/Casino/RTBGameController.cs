namespace ScheduleOne.Casino
{
	public class RTBGameController : global::ScheduleOne.Casino.CasinoGameController
	{
		public enum EStage
		{
			WaitingForPlayers = 0,
			RedOrBlack = 1,
			HigherOrLower = 2,
			InsideOrOutside = 3,
			Suit = 4
		}

		public const int BET_MINIMUM = 10;

		public const int BET_MAXIMUM = 500;

		public const float ANSWER_MAX_TIME = 6f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform PlayCameraTransform;

		public global::UnityEngine.Transform FocusedCameraTransform;

		public global::ScheduleOne.Casino.PlayingCard[] Cards;

		public global::UnityEngine.Transform[] CardDefaultPositions;

		public global::UnityEngine.Transform ActiveCardPosition;

		public global::UnityEngine.Transform[] DockedCardPositions;

		public global::System.Action<global::ScheduleOne.Casino.RTBGameController.EStage> onStageChange;

		public global::System.Action<string, string[]> onQuestionReady;

		public global::System.Action onQuestionDone;

		public global::System.Action onLocalPlayerCorrect;

		public global::System.Action onLocalPlayerIncorrect;

		public global::System.Action onLocalPlayerBetChange;

		public global::System.Action onLocalPlayerExitRound;

		private global::System.Collections.Generic.List<global::ScheduleOne.PlayerScripts.Player> playersInCurrentRound;

		private global::System.Collections.Generic.List<global::ScheduleOne.Casino.PlayingCard.CardData> cardsInDeck;

		private global::System.Collections.Generic.List<global::ScheduleOne.Casino.PlayingCard.CardData> drawnCards;

		private bool NetworkInitialize___EarlyScheduleOne_002ECasino_002ERTBGameControllerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECasino_002ERTBGameControllerAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Casino.RTBGameController.EStage CurrentStage { get; private set; }

		public bool IsQuestionActive { get; private set; }

		public float LocalPlayerBet { get; private set; }

		public float LocalPlayerBetMultiplier { get; private set; }

		public float MultipliedLocalPlayerBet => 0f;

		public float RemainingAnswerTime { get; private set; }

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

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetStage(global::ScheduleOne.Casino.RTBGameController.EStage stage)
		{
		}

		private void RunRound(global::ScheduleOne.Casino.RTBGameController.EStage stage)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetBetMultiplier(float multiplier)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void EndGame()
		{
		}

		public void RemoveLocalPlayerFromGame(bool payout, float cameraDelay = 0f)
		{
		}

		private bool IsCurrentRoundEmpty()
		{
			return false;
		}

		private float GetAnswerIndex(global::ScheduleOne.Casino.RTBGameController.EStage stage, global::ScheduleOne.Casino.PlayingCard.CardData card)
		{
			return 0f;
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void NotifyAnswer(float answerIndex)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void QuestionDone()
		{
		}

		private void GetQuestionsAndAnswers(global::ScheduleOne.Casino.RTBGameController.EStage stage, out string question, out string[] answers)
		{
			question = null;
			answers = null;
		}

		private void ResetCards()
		{
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

		private global::ScheduleOne.Casino.PlayingCard.CardData PullCardFromDeck()
		{
			return default(global::ScheduleOne.Casino.PlayingCard.CardData);
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

		public void SetLocalPlayerAnswer(float answer)
		{
		}

		public int GetAnsweredPlayersCount()
		{
			return 0;
		}

		public void ToggleLocalPlayerReady()
		{
		}

		private int GetCardNumberValue(global::ScheduleOne.Casino.PlayingCard.CardData card)
		{
			return 0;
		}

		public static float GetNetBetMultiplier(global::ScheduleOne.Casino.RTBGameController.EStage stage)
		{
			return 0f;
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

		private void RpcWriter___Observers_SetStage_2502303021(global::ScheduleOne.Casino.RTBGameController.EStage stage)
		{
		}

		private void RpcLogic___SetStage_2502303021(global::ScheduleOne.Casino.RTBGameController.EStage stage)
		{
		}

		private void RpcReader___Observers_SetStage_2502303021(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetBetMultiplier_431000436(float multiplier)
		{
		}

		private void RpcLogic___SetBetMultiplier_431000436(float multiplier)
		{
		}

		private void RpcReader___Observers_SetBetMultiplier_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
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

		private void RpcWriter___Observers_NotifyAnswer_431000436(float answerIndex)
		{
		}

		private void RpcLogic___NotifyAnswer_431000436(float answerIndex)
		{
		}

		private void RpcReader___Observers_NotifyAnswer_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_QuestionDone_2166136261()
		{
		}

		private void RpcLogic___QuestionDone_2166136261()
		{
		}

		private void RpcReader___Observers_QuestionDone_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ECasino_002ERTBGameController_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
