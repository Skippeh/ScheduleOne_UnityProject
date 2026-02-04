namespace ScheduleOne.Quests
{
	public class Quest_WeNeedToCook : global::ScheduleOne.Quests.Quest
	{
		public global::ScheduleOne.Quests.Quest[] PrerequisiteQuests;

		public global::ScheduleOne.Economy.Supplier MethSupplier;

		protected override void OnUncappedMinPass()
		{
		}
	}
}
