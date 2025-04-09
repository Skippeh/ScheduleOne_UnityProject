using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	public class StartDryingRackBehaviour : Behaviour
	{
		public const float TIME_PER_ITEM = 1f;

		private Coroutine workRoutine;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EStartDryingRackBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EStartDryingRackBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public DryingRack Rack { get; protected set; }

		public bool WorkInProgress { get; protected set; }

		protected override void Begin()
		{
		}

		protected override void Resume()
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

		public override void ActiveMinPass()
		{
		}

		private void StartWork()
		{
		}

		public void AssignRack(DryingRack rack)
		{
		}

		public bool IsAtStation()
		{
			return false;
		}

		public void GoToStation()
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void BeginAction()
		{
		}

		private void StopCauldron()
		{
		}

		public bool IsRackReady(DryingRack rack)
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

		private void RpcReader___Observers_BeginAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
