namespace ScheduleOne.Quests
{
	public class Quest_UnfavourableAgreements : global::ScheduleOne.Quests.Quest
	{
		public global::ScheduleOne.Vehicles.LandVehicle MeetingVehicle;

		public global::UnityEngine.Transform VehicleSpawnPoint;

		public global::ScheduleOne.Map.ParkingLot ParkingLot;

		public global::ScheduleOne.NPCs.CharacterClasses.Thomas Thomas;

		public global::ScheduleOne.Quests.QuestEntry ReadMessageQuestEntry;

		public global::ScheduleOne.Quests.QuestEntry MeetingQuestEntry;

		public global::UnityEngine.Events.UnityEvent onMeetingConcluded;

		protected override void Start()
		{
		}

		private void CheckQuestStart()
		{
		}

		public override void Begin(bool network = true)
		{
		}

		protected override void MinPass()
		{
		}

		public override void SetQuestState(global::ScheduleOne.Quests.EQuestState state, bool network = true)
		{
		}

		private void MeetingEnded()
		{
		}

		private void DriveCallback(global::ScheduleOne.Vehicles.AI.VehicleAgent.ENavigationResult result)
		{
		}

		private void Park()
		{
		}
	}
}
