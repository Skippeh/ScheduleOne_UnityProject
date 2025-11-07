namespace ScheduleOne.NPCs.Behaviour
{
	public class CallPoliceBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		public const float CALL_POLICE_TIME = 4f;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.UI.WorldspacePopup.WorldspacePopup PhoneCallPopup;

		public global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable PhonePrefab;

		public global::ScheduleOne.Audio.AudioSourceController CallSound;

		private float currentCallTime;

		public global::ScheduleOne.PlayerScripts.Player Target;

		public global::ScheduleOne.Law.Crime ReportedCrime;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002ECallPoliceBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002ECallPoliceBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public override void Begin()
		{
		}

		public void SetData(global::FishNet.Object.NetworkObject player, global::ScheduleOne.Law.Crime crime)
		{
		}

		public override void Resume()
		{
		}

		public override void End()
		{
		}

		public override void Pause()
		{
		}

		public override void BehaviourUpdate()
		{
		}

		private void RefreshIcon()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
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

		private void RpcReader___Observers_FinalizeCall_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
