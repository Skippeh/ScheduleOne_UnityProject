namespace ScheduleOne.NPCs.Behaviour
{
	public class StartMixingStationBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		public const float INSERT_INGREDIENT_BASE_TIME = 1f;

		private global::ScheduleOne.Employees.Chemist chemist;

		private global::UnityEngine.Coroutine startRoutine;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EStartMixingStationBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EStartMixingStationBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.ObjectScripts.MixingStation targetStation { get; private set; }

		public override void Awake()
		{
		}

		public void AssignStation(global::ScheduleOne.ObjectScripts.MixingStation station)
		{
		}

		public override void Deactivate()
		{
		}

		public override void Pause()
		{
		}

		public override void OnActiveTick()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void StartCook()
		{
		}

		private bool CanCookStart()
		{
			return false;
		}

		private void StopCook()
		{
		}

		private global::UnityEngine.Vector3 GetStationAccessPoint()
		{
			return default(global::UnityEngine.Vector3);
		}

		private bool IsAtStation()
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

		private void RpcWriter___Observers_StartCook_2166136261()
		{
		}

		private void RpcLogic___StartCook_2166136261()
		{
		}

		private void RpcReader___Observers_StartCook_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002EStartMixingStationBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
