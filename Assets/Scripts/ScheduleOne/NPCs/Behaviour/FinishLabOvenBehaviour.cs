namespace ScheduleOne.NPCs.Behaviour
{
	public class FinishLabOvenBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		public const float HARVEST_TIME = 10f;

		private global::ScheduleOne.Employees.Chemist chemist;

		private global::UnityEngine.Coroutine actionRoutine;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EFinishLabOvenBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EFinishLabOvenBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.ObjectScripts.LabOven targetOven { get; private set; }

		public override void Awake()
		{
		}

		public void SetTargetOven(global::ScheduleOne.ObjectScripts.LabOven oven)
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
		private void StartAction()
		{
		}

		private bool CanActionStart()
		{
			return false;
		}

		private void StopAction()
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

		private void RpcWriter___Observers_StartAction_2166136261()
		{
		}

		private void RpcLogic___StartAction_2166136261()
		{
		}

		private void RpcReader___Observers_StartAction_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002EFinishLabOvenBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
