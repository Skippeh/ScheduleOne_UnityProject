using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Employees;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	public class FinishLabOvenBehaviour : Behaviour
	{
		public const float HARVEST_TIME = 10f;

		private Chemist chemist;

		private Coroutine actionRoutine;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EFinishLabOvenBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EFinishLabOvenBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public LabOven targetOven { get; private set; }

		public override void Awake()
		{
		}

		public void SetTargetOven(LabOven oven)
		{
		}

		protected override void End()
		{
		}

		public override void ActiveMinPass()
		{
		}

		[ObserversRpc(RunLocally = true)]
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

		private Vector3 GetStationAccessPoint()
		{
			return default(Vector3);
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

		private void RpcReader___Observers_StartAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002EFinishLabOvenBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
