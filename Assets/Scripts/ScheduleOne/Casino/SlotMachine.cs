namespace ScheduleOne.Casino
{
	public class SlotMachine : global::FishNet.Object.NetworkBehaviour
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

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Interaction.InteractableObject DownButton;

		public global::ScheduleOne.Interaction.InteractableObject UpButton;

		public global::ScheduleOne.Interaction.InteractableObject HandleIntObj;

		public global::TMPro.TextMeshPro BetAmountLabel;

		public global::ScheduleOne.Casino.SlotReel[] Reels;

		public global::ScheduleOne.Audio.AudioSourceController SpinLoop;

		public global::UnityEngine.Animation ScreenAnimation;

		public global::UnityEngine.ParticleSystem[] JackpotParticles;

		[global::UnityEngine.Header("Win Animations")]
		public global::TMPro.TextMeshProUGUI[] WinAmountLabels;

		public global::UnityEngine.AnimationClip MiniWinAnimation;

		public global::UnityEngine.AnimationClip SmallWinAnimation;

		public global::UnityEngine.AnimationClip BigWinAnimation;

		public global::UnityEngine.AnimationClip JackpotAnimation;

		public global::ScheduleOne.Audio.AudioSourceController MiniWinSound;

		public global::ScheduleOne.Audio.AudioSourceController SmallWinSound;

		public global::ScheduleOne.Audio.AudioSourceController BigWinSound;

		public global::ScheduleOne.Audio.AudioSourceController JackpotSound;

		public global::UnityEngine.Events.UnityEvent onDownPressed;

		public global::UnityEngine.Events.UnityEvent onUpPressed;

		public global::UnityEngine.Events.UnityEvent onHandlePulled;

		private int currentBetIndex;

		private bool NetworkInitialize___EarlyScheduleOne_002ECasino_002ESlotMachineAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECasino_002ESlotMachineAssembly_002DCSharp_002Edll_Excuted;

		public bool IsSpinning { get; private set; }

		private int currentBetAmount => 0;

		public virtual void Awake()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
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

		[global::EasyButtons.Button]
		public void HandleInteracted()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendBetIndex(int index)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetBetIndex(global::FishNet.Connection.NetworkConnection conn, int index)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendStartSpin(global::FishNet.Connection.NetworkConnection spinner, int betAmount)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void StartSpin(global::FishNet.Connection.NetworkConnection spinner, global::ScheduleOne.Casino.SlotMachine.ESymbol[] symbols, int betAmount)
		{
		}

		private global::ScheduleOne.Casino.SlotMachine.EOutcome EvaluateOutcome(global::ScheduleOne.Casino.SlotMachine.ESymbol[] outcome)
		{
			return default(global::ScheduleOne.Casino.SlotMachine.EOutcome);
		}

		private int GetWinAmount(global::ScheduleOne.Casino.SlotMachine.EOutcome outcome, int betAmount)
		{
			return 0;
		}

		private void DisplayOutcome(global::ScheduleOne.Casino.SlotMachine.EOutcome outcome, int winAmount)
		{
		}

		public static global::ScheduleOne.Casino.SlotMachine.ESymbol GetRandomSymbol()
		{
			return default(global::ScheduleOne.Casino.SlotMachine.ESymbol);
		}

		private bool IsFruit(global::ScheduleOne.Casino.SlotMachine.ESymbol symbol)
		{
			return false;
		}

		private bool IsAllFruit(global::ScheduleOne.Casino.SlotMachine.ESymbol[] symbols)
		{
			return false;
		}

		private bool IsUniform(global::ScheduleOne.Casino.SlotMachine.ESymbol[] symbols)
		{
			return false;
		}

		[global::EasyButtons.Button]
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

		private void RpcReader___Server_SendBetIndex_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetBetIndex_2681120339(global::FishNet.Connection.NetworkConnection conn, int index)
		{
		}

		public void RpcLogic___SetBetIndex_2681120339(global::FishNet.Connection.NetworkConnection conn, int index)
		{
		}

		private void RpcReader___Observers_SetBetIndex_2681120339(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetBetIndex_2681120339(global::FishNet.Connection.NetworkConnection conn, int index)
		{
		}

		private void RpcReader___Target_SetBetIndex_2681120339(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendStartSpin_2681120339(global::FishNet.Connection.NetworkConnection spinner, int betAmount)
		{
		}

		public void RpcLogic___SendStartSpin_2681120339(global::FishNet.Connection.NetworkConnection spinner, int betAmount)
		{
		}

		private void RpcReader___Server_SendStartSpin_2681120339(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_StartSpin_2659526290(global::FishNet.Connection.NetworkConnection spinner, global::ScheduleOne.Casino.SlotMachine.ESymbol[] symbols, int betAmount)
		{
		}

		public void RpcLogic___StartSpin_2659526290(global::FishNet.Connection.NetworkConnection spinner, global::ScheduleOne.Casino.SlotMachine.ESymbol[] symbols, int betAmount)
		{
		}

		private void RpcReader___Observers_StartSpin_2659526290(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void Awake_UserLogic_ScheduleOne_002ECasino_002ESlotMachine_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
