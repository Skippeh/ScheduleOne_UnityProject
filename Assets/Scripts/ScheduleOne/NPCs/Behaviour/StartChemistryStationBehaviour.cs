namespace ScheduleOne.NPCs.Behaviour
{
	public class StartChemistryStationBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		public const float PLACE_INGREDIENTS_TIME = 8f;

		public const float STIR_TIME = 6f;

		public const float BURNER_TIME = 6f;

		private global::ScheduleOne.Employees.Chemist chemist;

		private global::UnityEngine.Coroutine cookRoutine;

		private global::ScheduleOne.ObjectScripts.Beaker beaker;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EStartChemistryStationBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EStartChemistryStationBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.ObjectScripts.ChemistryStation targetStation { get; private set; }

		public override void Awake()
		{
		}

		public void SetTargetStation(global::ScheduleOne.ObjectScripts.ChemistryStation station)
		{
		}

		public override void Deactivate()
		{
		}

		public override void OnActiveTick()
		{
		}

		public override void BehaviourUpdate()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void StartCook()
		{
		}

		private void SetupBeaker()
		{
		}

		private void FillBeaker(global::ScheduleOne.StationFramework.StationRecipe recipe, global::ScheduleOne.ObjectScripts.Beaker beaker)
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002EStartChemistryStationBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
