namespace ScheduleOne.NPCs.Behaviour
{
	public class PackagingStationBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		public const float BASE_PACKAGING_TIME = 5f;

		private global::UnityEngine.Coroutine packagingRoutine;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EPackagingStationBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EPackagingStationBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.ObjectScripts.PackagingStation Station { get; protected set; }

		public bool PackagingInProgress { get; protected set; }

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

		private void StartPackaging()
		{
		}

		public void AssignStation(global::ScheduleOne.ObjectScripts.PackagingStation station)
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
		public void BeginPackaging()
		{
		}

		private void StopPackaging()
		{
		}

		public bool IsStationReady(global::ScheduleOne.ObjectScripts.PackagingStation station)
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

		private void RpcWriter___Observers_BeginPackaging_2166136261()
		{
		}

		public void RpcLogic___BeginPackaging_2166136261()
		{
		}

		private void RpcReader___Observers_BeginPackaging_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
