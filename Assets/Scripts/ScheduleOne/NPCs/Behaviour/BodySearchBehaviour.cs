namespace ScheduleOne.NPCs.Behaviour
{
	public class BodySearchBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		public const global::ScheduleOne.Product.Packaging.EStealthLevel MAX_STEALTH_LEVEL = global::ScheduleOne.Product.Packaging.EStealthLevel.None;

		public const float BODY_SEARCH_RANGE = 2f;

		public const float MAX_SEARCH_TIME = 15f;

		public const float MAX_TIME_OUTSIDE_RANGE = 4f;

		public const float RANGE_TO_ESCALATE = 15f;

		public const float MOVE_SPEED = 0.15f;

		public const float BODY_SEARCH_COOLDOWN = 30f;

		[global::UnityEngine.Header("Settings")]
		public float ArrestCircle_MaxVisibleDistance;

		public float ArrestCircle_MaxOpacity;

		public bool ShowPostSearchDialogue;

		[global::UnityEngine.Header("Item of interest settings")]
		public global::ScheduleOne.Product.Packaging.EStealthLevel MaxStealthLevel;

		private global::ScheduleOne.Police.PoliceOfficer officer;

		private float targetDistanceOnStart;

		private float searchTime;

		private bool hasBeenInRange;

		private float timeOutsideRange;

		private float timeWithinSearchRange;

		private float timeSinceCantReach;

		[global::UnityEngine.Header("Events")]
		public global::UnityEngine.Events.UnityEvent onSearchComplete_Clear;

		public global::UnityEngine.Events.UnityEvent onSearchComplete_ItemsFound;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EBodySearchBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EBodySearchBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public static float BODY_SEARCH_TIME => 0f;

		public global::ScheduleOne.PlayerScripts.Player TargetPlayer { get; protected set; }

		private global::ScheduleOne.Dialogue.DialogueDatabase dialogueDatabase => null;

		public override void Awake()
		{
		}

		public override void Activate()
		{
		}

		public override void Resume()
		{
		}

		public override void Deactivate()
		{
		}

		public override void Pause()
		{
		}

		public override void BehaviourUpdate()
		{
		}

		private void UpdateSearch()
		{
		}

		protected virtual void UpdateMovement()
		{
		}

		private void SearchClean()
		{
		}

		private void SearchFail()
		{
		}

		private void UpdateEscalation()
		{
		}

		protected virtual void UpdateLookAt()
		{
		}

		protected virtual void UpdateCircle()
		{
		}

		private void SetArrestCircleAlpha(float alpha)
		{
		}

		private void SetArrestCircleColor(global::UnityEngine.Color col)
		{
		}

		private global::UnityEngine.Vector3 GetNewDestination()
		{
			return default(global::UnityEngine.Vector3);
		}

		private void ClearSpeedControls()
		{
		}

		private bool IsTargetValid(global::ScheduleOne.PlayerScripts.Player player)
		{
			return false;
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public virtual void AssignTarget(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject target)
		{
		}

		public virtual bool DoesPlayerContainItemsOfInterest()
		{
			return false;
		}

		public virtual void ConcludeSearch(bool clear)
		{
		}

		public virtual void Escalate()
		{
		}

		public virtual void NoItemsOfInterestFound()
		{
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

		private void RpcWriter___Observers_AssignTarget_1824087381(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject target)
		{
		}

		public virtual void RpcLogic___AssignTarget_1824087381(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject target)
		{
		}

		private void RpcReader___Observers_AssignTarget_1824087381(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002EBodySearchBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
