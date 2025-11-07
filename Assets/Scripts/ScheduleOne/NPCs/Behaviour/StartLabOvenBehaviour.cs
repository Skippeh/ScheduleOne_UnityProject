namespace ScheduleOne.NPCs.Behaviour
{
	public class StartLabOvenBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		public const float POUR_TIME = 5f;

		private global::ScheduleOne.Employees.Chemist chemist;

		private global::UnityEngine.Coroutine cookRoutine;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EStartLabOvenBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EStartLabOvenBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.ObjectScripts.LabOven targetOven { get; private set; }

		public override void Awake()
		{
		}

		public void SetTargetOven(global::ScheduleOne.ObjectScripts.LabOven oven)
		{
		}

		public override void End()
		{
		}

		public override void ActiveMinPass()
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002EStartLabOvenBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
