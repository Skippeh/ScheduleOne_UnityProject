namespace ScheduleOne.NPCs.Behaviour
{
	public class PursuitBehaviour : global::ScheduleOne.Combat.CombatBehaviour
	{
		private enum EPursuitAction
		{
			None = 0,
			Move = 1,
			Shoot = 2,
			MoveAndShoot = 3
		}

		public const float ARREST_RANGE = 2.75f;

		public const float ARREST_TIME = 1.75f;

		public const float EXTRA_VISIBILITY_TIME = 2f;

		public const float MOVE_SPEED_INVESTIGATING = 0.35f;

		public const float MOVE_SPEED_ARRESTING = 0.65f;

		public const float MOVE_SPEED_CHASE = 0.9f;

		public const float ARREST_MAX_DISTANCE = 15f;

		public const int LEAVE_ARREST_CIRCLE_LIMIT = 3;

		[global::UnityEngine.Header("Settings")]
		public float ArrestCircle_MaxVisibleDistance;

		public float ArrestCircle_MaxOpacity;

		[global::UnityEngine.Header("Weapons")]
		public global::ScheduleOne.AvatarFramework.Equipping.AvatarWeapon Weapon_Baton;

		public global::ScheduleOne.AvatarFramework.Equipping.AvatarWeapon Weapon_Taser;

		public global::ScheduleOne.AvatarFramework.Equipping.AvatarWeapon Weapon_Gun;

		protected bool arrestingEnabled;

		protected float currentPursuitLevelDuration;

		protected float timeWithinArrestRange;

		protected float distanceOnPursuitStart;

		private global::ScheduleOne.Police.PoliceOfficer officer;

		private bool targetWasDrivingOnPursuitStart;

		private bool wasInArrestCircleLastFrame;

		private int leaveArrestCircleCount;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EPursuitBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EPursuitBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.PlayerScripts.Player TargetPlayer { get; protected set; }

		public override void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		protected override void SetTarget(global::FishNet.Object.NetworkObject target)
		{
		}

		public override void Begin()
		{
		}

		public override void Resume()
		{
		}

		public override void Disable()
		{
		}

		public override void BehaviourUpdate()
		{
		}

		public override void ActiveMinPass()
		{
		}

		protected override bool IsTargetValid()
		{
			return false;
		}

		protected virtual void UpdateInvestigatingBehaviour()
		{
		}

		protected virtual void UpdateArrestBehaviour()
		{
		}

		protected virtual void UpdateNonLethalBehaviour()
		{
		}

		protected virtual void UpdateLethalBehaviour()
		{
		}

		protected override void OnCurrentWeaponChanged(global::ScheduleOne.AvatarFramework.Equipping.AvatarWeapon weapon)
		{
		}

		protected override float GetIdealRangedWeaponDistance()
		{
			return 0f;
		}

		private void UpdateArrest(float tick)
		{
		}

		private void ClearSpeedControls()
		{
		}

		protected override void EndCombat()
		{
		}

		protected virtual void UpdateArrestCircle()
		{
		}

		public void ResetArrestProgress()
		{
		}

		private void SetArrestCircleAlpha(float alpha)
		{
		}

		private void SetArrestCircleColor(global::UnityEngine.Color col)
		{
		}

		private void OnThirdPartyVisionEvent(global::ScheduleOne.Vision.VisionEventReceipt receipt)
		{
		}

		protected override void TargetSpotted()
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002EPursuitBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
