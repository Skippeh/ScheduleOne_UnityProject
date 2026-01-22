namespace ScheduleOne.Quests
{
	public class Quest_NeedingTheGreen : global::ScheduleOne.Quests.Quest
	{
		public global::ScheduleOne.Quests.Quest[] PrerequisiteQuests;

		public global::ScheduleOne.Quests.QuestEntry EarnEntry;

		public float LifetimeEarningsRequirement;

		protected override void OnMinPass()
		{
		}
	}
}
