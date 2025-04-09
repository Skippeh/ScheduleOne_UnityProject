using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.Law;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.WorldspacePopup;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	public class CallPoliceBehaviour : Behaviour
	{
		public const float CALL_POLICE_TIME = 4f;

		[Header("References")]
		public WorldspacePopup PhoneCallPopup;

		public AvatarEquippable PhonePrefab;

		public AudioSourceController CallSound;

		private float currentCallTime;

		public Player Target;

		public Crime ReportedCrime;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002ECallPoliceBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002ECallPoliceBehaviourAssembly_002DCSharp_002Edll_Excuted;

		protected override void Begin()
		{
		}

		public void SetData(NetworkObject player, Crime crime)
		{
		}

		protected override void Resume()
		{
		}

		protected override void End()
		{
		}

		protected override void Pause()
		{
		}

		public override void BehaviourUpdate()
		{
		}

		private void RefreshIcon()
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void FinalizeCall()
		{
		}

		private bool IsTargetValid()
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

		private void RpcWriter___Observers_FinalizeCall_2166136261()
		{
		}

		private void RpcLogic___FinalizeCall_2166136261()
		{
		}

		private void RpcReader___Observers_FinalizeCall_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
