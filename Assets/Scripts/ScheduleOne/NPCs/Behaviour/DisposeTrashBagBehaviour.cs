namespace ScheduleOne.NPCs.Behaviour
{
	public class DisposeTrashBagBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		public string TRASH_BAG_ASSET_PATH;

		public const float GRAB_MAX_DISTANCE = 2f;

		private global::ScheduleOne.Trash.TrashContent heldTrash;

		private global::UnityEngine.Coroutine grabRoutine;

		private global::UnityEngine.Coroutine dropRoutine;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EDisposeTrashBagBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EDisposeTrashBagBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Trash.TrashBag TargetBag { get; private set; }

		private global::ScheduleOne.Employees.Cleaner Cleaner => null;

		public void SetTargetBag(global::ScheduleOne.Trash.TrashBag bag)
		{
		}

		public override void Activate()
		{
		}

		public override void Resume()
		{
		}

		private void StartAction()
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

		private void StopAllActions()
		{
		}

		public override void OnActiveTick()
		{
		}

		private void GoToTarget()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void GrabTrash()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void DropTrash()
		{
		}

		private bool IsAtDestination()
		{
			return false;
		}

		private bool AreActionConditionsMet(bool checkAccess)
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

		private void RpcWriter___Observers_GrabTrash_2166136261()
		{
		}

		private void RpcLogic___GrabTrash_2166136261()
		{
		}

		private void RpcReader___Observers_GrabTrash_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_DropTrash_2166136261()
		{
		}

		private void RpcLogic___DropTrash_2166136261()
		{
		}

		private void RpcReader___Observers_DropTrash_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
