using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Employees;
using ScheduleOne.ObjectScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Behaviour
{
	public class EmptyTrashGrabberBehaviour : Behaviour
	{
		public const float ACTION_MAX_DISTANCE = 2f;

		public const string EQUIPPABLE_ASSET_PATH = "Tools/TrashGrabber/Bin_AvatarEquippable";

		private Coroutine actionCoroutine;

		public UnityEvent onPerfomAction;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EEmptyTrashGrabberBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EEmptyTrashGrabberBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public TrashContainerItem TargetTrashCan { get; private set; }

		private Cleaner Cleaner => null;

		public void SetTargetTrashCan(TrashContainerItem trashCan)
		{
		}

		protected override void Begin()
		{
		}

		protected override void Resume()
		{
		}

		private void StartAction()
		{
		}

		protected override void Pause()
		{
		}

		public override void Disable()
		{
		}

		protected override void End()
		{
		}

		private void StopAllActions()
		{
		}

		public override void ActiveMinPass()
		{
		}

		private void GoToTarget()
		{
		}

		[ObserversRpc(RunLocally = true)]
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

		private void RpcReader___Observers_PerformAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
