using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	public class StartCauldronBehaviour : Behaviour
	{
		public const float START_CAULDRON_TIME = 15f;

		private Coroutine workRoutine;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EStartCauldronBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EStartCauldronBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public Cauldron Station { get; protected set; }

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

		public void AssignStation(Cauldron station)
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
		public void BeginCauldron()
		{
		}

		private void StopCauldron()
		{
		}

		public bool IsStationReady(Cauldron station)
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

		private void RpcWriter___Observers_BeginCauldron_2166136261()
		{
		}

		public void RpcLogic___BeginCauldron_2166136261()
		{
		}

		private void RpcReader___Observers_BeginCauldron_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
