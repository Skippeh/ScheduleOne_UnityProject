namespace ScheduleOne.Quests
{
	public class Quest_GearingUp : global::ScheduleOne.Quests.Quest
	{
		public global::ScheduleOne.Quests.QuestEntry WaitForDropEntry;

		public global::ScheduleOne.Quests.QuestEntry CollectDropEntry;

		public global::ScheduleOne.Economy.Supplier Supplier;

		private bool setCollectionPosition;

		protected override void Start()
		{
		}

		protected override void OnUncappedMinPass()
		{
		}

		private void DropReady()
		{
		}
	}
}
