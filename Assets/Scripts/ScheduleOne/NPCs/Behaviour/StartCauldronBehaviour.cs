namespace ScheduleOne.NPCs.Behaviour
{
	public class StartCauldronBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		public const float START_CAULDRON_TIME = 15f;

		private global::UnityEngine.Coroutine workRoutine;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EStartCauldronBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EStartCauldronBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.ObjectScripts.Cauldron Station { get; protected set; }

		public bool WorkInProgress { get; protected set; }

		public override void Activate()
		{
		}

		public override void Resume()
		{
		}

		public override void Pause()
		{
		}

		public override void Disable()
		{
		}

		public override void Deactivate()
		{
		}

		public override void OnActiveTick()
		{
		}

		private void StartWork()
		{
		}

		public void AssignStation(global::ScheduleOne.ObjectScripts.Cauldron station)
		{
		}

		public bool IsAtStation()
		{
			return false;
		}

		public void GoToStation()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void BeginCauldron()
		{
		}

		private void StopCauldron()
		{
		}

		public bool IsStationReady(global::ScheduleOne.ObjectScripts.Cauldron station)
		{
			return false;
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

		private void RpcWriter___Observers_BeginCauldron_2166136261()
		{
		}

		public void RpcLogic___BeginCauldron_2166136261()
		{
		}

		private void RpcReader___Observers_BeginCauldron_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
