using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Employees;
using ScheduleOne.Trash;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	public class DisposeTrashBagBehaviour : Behaviour
	{
		public string TRASH_BAG_ASSET_PATH;

		public const float GRAB_MAX_DISTANCE = 2f;

		private TrashContent heldTrash;

		private Coroutine grabRoutine;

		private Coroutine dropRoutine;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EDisposeTrashBagBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EDisposeTrashBagBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public TrashBag TargetBag { get; private set; }

		private Cleaner Cleaner => null;

		public void SetTargetBag(TrashBag bag)
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
		private void GrabTrash()
		{
		}

		[ObserversRpc(RunLocally = true)]
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

		private void RpcReader___Observers_GrabTrash_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_DropTrash_2166136261()
		{
		}

		private void RpcLogic___DropTrash_2166136261()
		{
		}

		private void RpcReader___Observers_DropTrash_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
