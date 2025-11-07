namespace ScheduleOne.NPCs.Behaviour
{
	public class FootPatrolBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		public const float MOVE_SPEED = 0.08f;

		public const int FLASHLIGHT_MIN_TIME = 1930;

		public int FLASHLIGHT_MAX_TIME;

		public const string FLASHLIGHT_ASSET_PATH = "Tools/Flashlight/Flashlight_AvatarEquippable";

		public bool UseFlashlight;

		private bool flashlightEquipped;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EFootPatrolBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EFootPatrolBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.NPCs.Behaviour.PatrolGroup Group { get; protected set; }

		public override void Begin()
		{
		}

		public override void Resume()
		{
		}

		public override void Pause()
		{
		}

		public override void End()
		{
		}

		public override void ActiveMinPass()
		{
		}

		private void SetFlashlightEquipped(bool equipped)
		{
		}

		public void SetGroup(global::ScheduleOne.NPCs.Behaviour.PatrolGroup group)
		{
		}

		public bool IsReadyToAdvance()
		{
			return false;
		}

		private bool IsAtDestination()
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

		public override void Awake()
		{
		}
	}
}
