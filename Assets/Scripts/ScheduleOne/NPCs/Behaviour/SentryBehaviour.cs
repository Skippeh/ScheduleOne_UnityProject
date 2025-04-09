using ScheduleOne.Law;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	public class SentryBehaviour : Behaviour
	{
		public const float BODY_SEARCH_CHANCE = 0.75f;

		public const int FLASHLIGHT_MIN_TIME = 1930;

		public int FLASHLIGHT_MAX_TIME;

		public const string FLASHLIGHT_ASSET_PATH = "Tools/Flashlight/Flashlight_AvatarEquippable";

		public bool UseFlashlight;

		private bool flashlightEquipped;

		private PoliceOfficer officer;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002ESentryBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002ESentryBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public SentryLocation AssignedLocation { get; private set; }

		private Transform standPoint => null;

		public override void Awake()
		{
		}

		protected override void Begin()
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

		public override void Disable()
		{
		}

		public void AssignLocation(SentryLocation loc)
		{
		}

		public void UnassignLocation()
		{
		}

		public override void ActiveMinPass()
		{
		}

		private void SetFlashlightEquipped(bool equipped)
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
