namespace ScheduleOne.NPCs.Behaviour
{
	public class UseSpawnStationBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		private const float TaskDuration = 6f;

		private const float ProximityThreshold = 0.5f;

		private const string AnimationBoolName = "UsePackagingStation";

		private bool _currentlyUsingStation;

		private global::UnityEngine.Coroutine _workRoutine;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EUseSpawnStationBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EUseSpawnStationBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.StationFramework.MushroomSpawnStation Station { get; protected set; }

		public void AssignStation(global::ScheduleOne.StationFramework.MushroomSpawnStation station)
		{
		}

		public override void Activate()
		{
		}

		public override void Deactivate()
		{
		}

		public override void Resume()
		{
		}

		public override void Pause()
		{
		}

		public override void OnActiveTick()
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
		public void BeginWork()
		{
		}

		private void StopWork()
		{
		}

		public bool IsStationReady(global::ScheduleOne.StationFramework.MushroomSpawnStation station)
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

		private void RpcWriter___Observers_BeginWork_2166136261()
		{
		}

		public void RpcLogic___BeginWork_2166136261()
		{
		}

		private void RpcReader___Observers_BeginWork_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
