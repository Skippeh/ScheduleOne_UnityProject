namespace ScheduleOne.NPCs.Behaviour
{
	public class StopDryingRackBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		public const float TIME_PER_ITEM = 1f;

		private global::UnityEngine.Coroutine workRoutine;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EStopDryingRackBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EStopDryingRackBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.ObjectScripts.DryingRack Rack { get; protected set; }

		public bool WorkInProgress { get; protected set; }

		public override void Begin()
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

		public override void End()
		{
		}

		public override void ActiveMinPass()
		{
		}

		private void StartWork()
		{
		}

		public void AssignRack(global::ScheduleOne.ObjectScripts.DryingRack rack)
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
		public void BeginAction()
		{
		}

		private void StopCauldron()
		{
		}

		public bool IsRackReady(global::ScheduleOne.ObjectScripts.DryingRack rack)
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

		private void RpcWriter___Observers_BeginAction_2166136261()
		{
		}

		public void RpcLogic___BeginAction_2166136261()
		{
		}

		private void RpcReader___Observers_BeginAction_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
