namespace ScheduleOne.NPCs.Behaviour
{
	public class SentryBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		private const float BodySearchChance = 0.75f;

		private const int FlashlightMinTime = 1930;

		private int FlashlightMaxTime;

		private const string FlashlightAssetPath = "Tools/Flashlight/Flashlight_AvatarEquippable";

		private const float AngularSpeedMultiplier = 0.2f;

		private const float WalkSpeed = 0.035f;

		public bool UseFlashlight;

		private bool flashlightEquipped;

		private global::ScheduleOne.Police.PoliceOfficer officer;

		private int _currentRoutePointIndex;

		private int _minutesAtCurrentPoint;

		private bool _movementModifiersApplied;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002ESentryBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002ESentryBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Law.SentryLocation AssignedLocation { get; private set; }

		private global::ScheduleOne.Law.SentryLocation.SentryRoute _currentRoute => null;

		private global::UnityEngine.Transform _standPoint => null;

		public override void Awake()
		{
		}

		public override void Deactivate()
		{
		}

		public override void Pause()
		{
		}

		public override void Disable()
		{
		}

		public void AssignLocation(global::ScheduleOne.Law.SentryLocation loc)
		{
		}

		public void UnassignLocation()
		{
		}

		public override void OnActiveTick()
		{
		}

		public override void OnActiveUncappedMinutePass()
		{
		}

		private bool IsAtStandPoint()
		{
			return false;
		}

		private void SetFlashlightEquipped(bool equipped)
		{
		}

		private void ApplyMovementModifiers()
		{
		}

		private void RemoveMovementModifiers()
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002ESentryBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
