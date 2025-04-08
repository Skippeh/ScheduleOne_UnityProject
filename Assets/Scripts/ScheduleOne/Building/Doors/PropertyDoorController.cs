namespace ScheduleOne.Building.Doors
{
	public class PropertyDoorController : global::ScheduleOne.Doors.DoorController
	{
		public const float WANTED_PLAYER_CLOSE_DISTANCE = 20f;

		public global::ScheduleOne.Property.Property Property;

		private bool IsUnlocked;

		private bool NetworkInitialize___EarlyScheduleOne_002EBuilding_002EDoors_002EPropertyDoorControllerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EBuilding_002EDoors_002EPropertyDoorControllerAssembly_002DCSharp_002Edll_Excuted;

		public override void Awake()
		{
		}

		public void Unlock()
		{
		}

		private void CheckClose()
		{
		}

		protected override bool CanPlayerAccess(global::ScheduleOne.Doors.EDoorSide side, out string reason)
		{
			reason = null;
			return false;
		}

		private global::ScheduleOne.PlayerScripts.Player GetNearestWantedPlayer()
		{
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

		protected virtual void Awake_UserLogic_ScheduleOne_002EBuilding_002EDoors_002EPropertyDoorController_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
