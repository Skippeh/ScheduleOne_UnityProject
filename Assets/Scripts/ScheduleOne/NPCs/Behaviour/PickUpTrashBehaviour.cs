namespace ScheduleOne.NPCs.Behaviour
{
	public class PickUpTrashBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		public const float ACTION_MAX_DISTANCE = 2f;

		public const string EQUIPPABLE_ASSET_PATH = "Tools/TrashGrabber/TrashGrabber_AvatarEquippable";

		private global::UnityEngine.Coroutine actionCoroutine;

		public global::UnityEngine.Events.UnityEvent onPerfomAction;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EPickUpTrashBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EPickUpTrashBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Trash.TrashItem TargetTrash { get; private set; }

		private global::ScheduleOne.Employees.Cleaner Cleaner => null;

		public void SetTargetTrash(global::ScheduleOne.Trash.TrashItem trash)
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
		private void PerformAction()
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

		private void RpcWriter___Observers_PerformAction_2166136261()
		{
		}

		private void RpcLogic___PerformAction_2166136261()
		{
		}

		private void RpcReader___Observers_PerformAction_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
