using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Employees;
using ScheduleOne.ObjectScripts;
using ScheduleOne.StationFramework;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	public class StartChemistryStationBehaviour : Behaviour
	{
		public const float PLACE_INGREDIENTS_TIME = 8f;

		public const float STIR_TIME = 6f;

		public const float BURNER_TIME = 6f;

		private Chemist chemist;

		private Coroutine cookRoutine;

		private Beaker beaker;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EStartChemistryStationBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EStartChemistryStationBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public ChemistryStation targetStation { get; private set; }

		public override void Awake()
		{
		}

		public void SetTargetStation(ChemistryStation station)
		{
		}

		protected override void End()
		{
		}

		public override void ActiveMinPass()
		{
		}

		public override void BehaviourUpdate()
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void StartCook()
		{
		}

		private void SetupBeaker()
		{
		}

		private void FillBeaker(StationRecipe recipe, Beaker beaker)
		{
		}

		private bool CanCookStart()
		{
			return false;
		}

		private void StopCook()
		{
		}

		private Vector3 GetStationAccessPoint()
		{
			return default(Vector3);
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

		private void RpcReader___Observers_StartCook_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002EStartChemistryStationBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
