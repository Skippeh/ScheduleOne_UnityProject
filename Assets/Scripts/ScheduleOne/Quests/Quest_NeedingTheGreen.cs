namespace ScheduleOne.Quests
{
	public class Quest_NeedingTheGreen : Quest
	{
		public Quest[] PrerequisiteQuests;

		public QuestEntry EarnEntry;

		public float LifetimeEarningsRequirement;

		protected override void MinPass()
		{
		}
	}
}
