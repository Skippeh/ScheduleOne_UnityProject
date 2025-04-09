using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Doors;
using ScheduleOne.Map;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	public class NPCEvent_StayInBuilding : NPCEvent
	{
		public NPCEnterableBuilding Building;

		[Header("Optionally specify door to use. Otherwise closest door will be used.")]
		public StaticDoor Door;

		private bool IsEntering;

		private Coroutine enterRoutine;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ESchedules_002ENPCEvent_StayInBuildingAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ESchedules_002ENPCEvent_StayInBuildingAssembly_002DCSharp_002Edll_Excuted;

		public new string ActionName => null;

		private bool InBuilding => false;

		public override void Awake()
		{
		}

		public override string GetName()
		{
			return null;
		}

		public override void Started()
		{
		}

		public override void ActiveMinPassed()
		{
		}

		public override void LateStarted()
		{
		}

		public override void JumpTo()
		{
		}

		public override void End()
		{
		}

		public override void Interrupt()
		{
		}

		public override void Skipped()
		{
		}

		public override void Resume()
		{
		}

		protected override void WalkCallback(NPCMovement.WalkResult result)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void PlayEnterAnimation()
		{
		}

		private void CancelEnter()
		{
		}

		private void EnterBuilding(int doorIndex)
		{
		}

		private void ExitBuilding()
		{
		}

		private Transform GetEntryPoint()
		{
			return null;
		}

		private StaticDoor GetDoor(out int doorIndex)
		{
			doorIndex = default(int);
			return null;
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

		private void RpcWriter___Observers_PlayEnterAnimation_2166136261()
		{
		}

		private void RpcLogic___PlayEnterAnimation_2166136261()
		{
		}

		private void RpcReader___Observers_PlayEnterAnimation_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002ESchedules_002ENPCEvent_StayInBuilding_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
