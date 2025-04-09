using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.Interaction;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Casino
{
	public class SlotMachine : NetworkBehaviour
	{
		public enum ESymbol
		{
			Cherry = 0,
			Lemon = 1,
			Grape = 2,
			Watermelon = 3,
			Bell = 4,
			Seven = 5
		}

		public enum EOutcome
		{
			Jackpot = 0,
			BigWin = 1,
			SmallWin = 2,
			MiniWin = 3,
			NoWin = 4
		}

		public static int[] BetAmounts;

		[Header("References")]
		public InteractableObject DownButton;

		public InteractableObject UpButton;

		public InteractableObject HandleIntObj;

		public TextMeshPro BetAmountLabel;

		public SlotReel[] Reels;

		public AudioSourceController SpinLoop;

		public Animation ScreenAnimation;

		public ParticleSystem[] JackpotParticles;

		[Header("Win Animations")]
		public TextMeshProUGUI[] WinAmountLabels;

		public AnimationClip MiniWinAnimation;

		public AnimationClip SmallWinAnimation;

		public AnimationClip BigWinAnimation;

		public AnimationClip JackpotAnimation;

		public AudioSourceController MiniWinSound;

		public AudioSourceController SmallWinSound;

		public AudioSourceController BigWinSound;

		public AudioSourceController JackpotSound;

		public UnityEvent onDownPressed;

		public UnityEvent onUpPressed;

		public UnityEvent onHandlePulled;

		private int currentBetIndex;

		private bool NetworkInitialize___EarlyScheduleOne_002ECasino_002ESlotMachineAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECasino_002ESlotMachineAssembly_002DCSharp_002Edll_Excuted;

		public bool IsSpinning { get; private set; }

		private int currentBetAmount => 0;

		public virtual void Awake()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		private void DownHovered()
		{
		}

		private void DownInteracted()
		{
		}

		private void UpHovered()
		{
		}

		private void UpInteracted()
		{
		}

		private void HandleHovered()
		{
		}

		[Button]
		public void HandleInteracted()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendBetIndex(int index)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetBetIndex(NetworkConnection conn, int index)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendStartSpin(NetworkConnection spinner, int betAmount)
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void StartSpin(NetworkConnection spinner, ESymbol[] symbols, int betAmount)
		{
		}

		private EOutcome EvaluateOutcome(ESymbol[] outcome)
		{
			return default(EOutcome);
		}

		private int GetWinAmount(EOutcome outcome, int betAmount)
		{
			return 0;
		}

		private void DisplayOutcome(EOutcome outcome, int winAmount)
		{
		}

		public static ESymbol GetRandomSymbol()
		{
			return default(ESymbol);
		}

		private bool IsFruit(ESymbol symbol)
		{
			return false;
		}

		private bool IsAllFruit(ESymbol[] symbols)
		{
			return false;
		}

		private bool IsUniform(ESymbol[] symbols)
		{
			return false;
		}

		[Button]
		public void SimulateMany()
		{
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

		private void RpcWriter___Server_SendBetIndex_3316948804(int index)
		{
		}

		private void RpcLogic___SendBetIndex_3316948804(int index)
		{
		}

		private void RpcReader___Server_SendBetIndex_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
		}

		public void RpcLogic___SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
		}

		private void RpcReader___Observers_SetBetIndex_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
		}

		private void RpcReader___Target_SetBetIndex_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendStartSpin_2681120339(NetworkConnection spinner, int betAmount)
		{
		}

		public void RpcLogic___SendStartSpin_2681120339(NetworkConnection spinner, int betAmount)
		{
		}

		private void RpcReader___Server_SendStartSpin_2681120339(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_StartSpin_2659526290(NetworkConnection spinner, ESymbol[] symbols, int betAmount)
		{
		}

		public void RpcLogic___StartSpin_2659526290(NetworkConnection spinner, ESymbol[] symbols, int betAmount)
		{
		}

		private void RpcReader___Observers_StartSpin_2659526290(PooledReader PooledReader0, Channel channel)
		{
		}

		private void Awake_UserLogic_ScheduleOne_002ECasino_002ESlotMachine_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
